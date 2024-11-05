using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        //Used for parts 1 and 2 when the user decided on the magic number: 
        //Console.Write("Please pick a magic number. ");
        //int magicNumber = int.Parse(Console.ReadLine());


        //Part 3 - Where the program randomly generates a magicNumber:
        Random randomGenerator = new Random();
        bool playing = true;
        
        do
        {
            int magicNumber = randomGenerator.Next(1, 101);
            int userGuess;
            bool correct = false;
            int counter = 0;

            do
            {
                counter += 1;
                Console.Write("What is your guess? ");
                userGuess = int.Parse(Console.ReadLine());

                if (userGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (userGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    correct = true;
                    Console.WriteLine($"That took you {counter} guesses");
                }
            } while (!correct);

            Console.Write("Do you want to play again? y or n? ");
            string answer = Console.ReadLine();

            if (answer == "n")
            {
                playing = false;
            }
            
        } while (playing);
    }
}