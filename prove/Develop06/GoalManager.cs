using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    private int _level = 0;

    public GoalManager()
    {
       
    }

    public void Start()
    {
        Console.Clear();

        int menuSelection;

        do 
        {    
            DisplayMenu();
            menuSelection = PromptUserForNumber("Select a choice from the menu: ", 6);
            MenuControl(menuSelection);
        } while (menuSelection != 6);
    }
        
    public void DisplayMenu()
    {
        DisplayPlayerInfo();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Quit");
    }

    void MenuControl(int menuSelection)
    {
        int menuItem = menuSelection;
        
        switch (menuItem)
        {
            case 1: //create new goal
                CreateGoal();
                break; 
            case 2: //list goals
                ListGoalDetails();
                break;
            case 3: //save goals
                SaveGoals();
                break;
            case 4: //load goals
                LoadGoals();
                break;
            case 5: //record event
                RecordEvent();
                break;
            default:
                break;
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.");
        Console.WriteLine($"You're on level {_level}; You're level name is {LevelName()}\n");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
    }

    public void ListGoalDetails()
    {
        int listNumber = 1;
        Console.WriteLine();

        foreach (Goal item in _goals)
        {
            string completed = " ";

            if (item.IsComplete())
            {
                completed = "X";
            }
            
            Console.WriteLine($"{listNumber}. [{completed}] {item.GetDetailsString()}");
            
            listNumber += 1;
        } 
    }

    public void CreateGoal()
    {
        ListGoalNames();
                
        int parsedChoice = PromptUserForNumber("Which type of goal would you like to create: ", 3);

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        string points = PromptUserForNumber("What is the number of points associated with this goal? ", -1).ToString();
        
        int bonus = 0;
        int target = 0;

        if (parsedChoice == 3)
        {
            target = PromptUserForNumber("How many times does this goal need to be accomplished for a bonus? ", -1);
            bonus = PromptUserForNumber("What is the bonus for accomplishing it that many times? ", -1);
        }

        switch (parsedChoice)
        {
            case 1:
                _goals.Add(new SimpleGoal(name, description, points)); 
                break;
            case 2:
                _goals.Add(new EternalGoal(name, description, points)); 
                break;
            case 3:
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus)); 
                break;
            default:
                break;
        }
    }

    public void RecordEvent()
    {
        ListGoalDetails();
        int completedGoal = PromptUserForNumber("What goal did you accomplish? ", _goals.Count());
        int index = completedGoal - 1;

        Goal currentGoal = _goals[index];
        currentGoal.RecordEvent();
        int points = currentGoal.GetParsedPoints();  
        _score += points;

        Console.WriteLine($"Congratulations! You have earned {points} points!");
        Console.WriteLine($"You now have {_score} points.");

        int nextLevel = _score/200;

        if (nextLevel > _level)
        {
            _level = nextLevel;
            LevelUp();
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the file name for the goal file? ");
        string fileName = Console.ReadLine();

        if (fileName == "") 
        {
            Console.WriteLine("Invalid filename.");
            return;
        }
        
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"{_score.ToString()}|{_level.ToString()}");

            foreach (Goal item in _goals)
            {
                outputFile.WriteLine(item.GetStringRepresentation());
            }
        }
        Console.WriteLine($"{fileName} was saved.");
    }

    public void LoadGoals()
    {
        Console.Write("What is the file name for the goal file? ");
        string fileName = Console.ReadLine();

        if (fileName == "") 
        {
            Console.WriteLine("Invalid filename.");
            return;
        }

        string[] lines = System.IO.File.ReadAllLines(fileName);

        if (lines.Length == 0)
        {
            Console.WriteLine("Error: File is Empty");
            return;
        }
        
        string[] score_level = lines[0].Split("|");
        _score = int.Parse(score_level[0]);
        _level = int.Parse(score_level[1]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");
            string goalType = parts[0];
            string name = parts[1];
            string description = parts[2];
            string points = parts[3];
            
            switch (goalType)
            {
                case "SimpleGoal":
                    SimpleGoal sg = new SimpleGoal(name, description, points);
                    string isCompleted = parts[4];
                    if (isCompleted == "True")
                    {
                        sg.RecordEvent();
                    }
                    _goals.Add(sg);
                    break;
                case "EternalGoal":
                    EternalGoal eg = new EternalGoal(name, description, points);
                    eg.RecordEvent();
                    _goals.Add(eg);
                    break;
                case "ChecklistGoal":
                    int target = int.Parse(parts[5]);
                    int bonus = int.Parse(parts[4]);
                    int amtCompleted = int.Parse(parts[6]);
                    ChecklistGoal cg = new ChecklistGoal(name, description, points, target, bonus);
                    for (int j = 0; j < amtCompleted; j++)
                    {
                        cg.RecordEvent();            
                    }
                    _goals.Add(cg);
                    break;
                default:
                    break;
            }
        }
    }

    private int PromptUserForNumber(string question, int maxNumber)
    {
        int parsedNumber = 0;
        bool valid = false;

        while (!valid)
        {
            Console.Write(question);
            string userInput = Console.ReadLine();

            bool successful = int.TryParse(userInput, out parsedNumber);
            if (successful)
            {
                if (maxNumber < 0)
                {
                    valid = true;
                }
                else if ((parsedNumber > 0) && (parsedNumber <= maxNumber))
                {
                    valid = true;
                }
                else 
                {
                    Console.WriteLine($"Please select a number from 1 to {maxNumber}");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input. Please enter a number.");
            }
        }
        return parsedNumber;
    }

    private void LevelUp()
    {
        Console.WriteLine("\n*******************************");
        Console.WriteLine("\tCongratulations!!");
        Console.WriteLine($"   You've Leveled Up to {_level} !!");
        Console.WriteLine("*******************************\n");

    }

    private string LevelName()
    {
        switch (_level)
        {
            case 0:
                return "Nursery";
            case 1:
                return "Sunbeam";
            case 2: 
                return "Star A";
            case 3:
                return "Star B";
            case 4: 
                return "CTR A";
            case 5: 
                return "CTR B";
            case 6: 
                return "Valiant A";
            case 7:
                return "Valiant B";
            default:
                return "Master GoalKeeper";
        }
    }
}


