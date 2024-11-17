using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    PromptGenerator prompt = new PromptGenerator();

    public void WriteEntry()
    {
        Entry entry = new Entry();
        entry._date = GetDate();
        entry._entryTime = GetTime();
        
        entry._promptText = prompt.GetRandomPrompt();
        if (entry._promptText == "No Prompts")
        {
            Console.WriteLine("*All prompts have been used for today. Come back tomorrow!");
            return;
        }
        Console.WriteLine(entry._promptText);
        string userEntry = Console.ReadLine();
        entry._entryText = userEntry; 
        AddEntry(entry);      
    }
    
    public string GetDate()
    {
        DateTime today = DateTime.Today;
        string journalDate = today.ToString("MM-dd-yyyy");
        return journalDate;
    }    

    public string GetTime()
    {
        DateTime currentTime = DateTime.Now;
        string journalTime = currentTime.ToString("hh:mm tt");
        return journalTime;
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("*Sorry, no entries available. Load a file first, or Write a new Entry.");
        }
            
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void LoadFromFile(string fileToLoad)
    {
        if (File.Exists(fileToLoad))
        {
            _entries.Clear();
            string[] lines = System.IO.File.ReadAllLines(fileToLoad);
             
            foreach (string line in lines)
            {
                Entry journalEntry = new Entry();
                string[] parts = line.Split("|");
                if (parts.Length == 4)
                {
                    string date = parts[0];
                    string entryTime = parts[1];
                    string promptText = parts[2];
                    string entryText = parts[3];

                    journalEntry._date = date;
                    journalEntry._entryTime = entryTime;
                    journalEntry._promptText = promptText;
                    journalEntry._entryText = entryText;

                    AddEntry(journalEntry);
                }            
            }
           
            Console.WriteLine("*Your file has been loaded.");
        } 
        else
        {
            Console.WriteLine("*That file does not exist. Try Again.");
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter outputToSave = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputToSave.WriteLine($"{entry._date}|{entry._entryTime}|{entry._promptText}|{entry._entryText}");
            }
            
            Console.WriteLine("*Your file has been saved.");        
        }
    }



}