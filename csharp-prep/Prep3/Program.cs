using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,100);
        Console.WriteLine("Try to guess the number between 1 and 100");
        string userEntry = Console.ReadLine();
        int userEntryInt = int.Parse(userEntry);
        while (userEntryInt != number)
        {
            if (userEntryInt > number)
            {
                Console.WriteLine("Lower");
            }
            else if (userEntryInt < number)
            {
                Console.WriteLine("Higher");
            }
            Console.WriteLine("Enter another guess: ");
            userEntry = Console.ReadLine();
            userEntryInt = int.Parse(userEntry);
        }
        Console.WriteLine($"You got it! The magic number was {number}");
    }
}