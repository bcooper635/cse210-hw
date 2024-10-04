using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        string journFile = "Journal.csv";
        PromptGenerator generatePrompt = new();
        Journal theJournal = new();
        Entry _objectEntry = new();
        
        int validation = 1;
        while (validation == 1)
        {
            Console.WriteLine("Welcome to Blake's Journal App");
            Console.WriteLine("Select one of the following:\n1. Write a new entry\n2. Load a journal entry\n3. Display all journal entries\n4.Save Journal Entry\n5. Quit");
            string userChoice = Console.ReadLine();
            int intChoice = int.Parse(userChoice);
            if (intChoice == 1)
            {
                Entry newEntry = new Entry();
                string prompt1 = generatePrompt.GetRandomPrompt();
                Console.WriteLine($"{prompt1}");
                string response1 = Console.ReadLine();
                DateTime date1 = DateTime.Now;
                

                newEntry._prompt = prompt1;
                newEntry._date = date1;
                newEntry._userEntry = response1;

                theJournal.AddEntry(newEntry);

                
            }
            else if (intChoice == 2)
            {
                theJournal.LoadFromFile(journFile);
            }
            else if (intChoice == 3)
            {
                theJournal.DisplayAll();
            }
            else if (intChoice == 4)
            {
                theJournal.SaveToFile(journFile);
            }
            else if (intChoice == 5)
            {
                Console.WriteLine("Quitting program, have a great day!!");
                validation = 0;
            }
            else
            {
                Console.WriteLine("Invalid entry. Must choose between 1, 2, or 3");
            }
        }

    }
}