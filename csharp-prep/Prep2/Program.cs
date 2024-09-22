using System;

class Program
{
    static void Main(string[] args)
    {
        string letter;
        Console.WriteLine("Let's determine your letter grade. What percentage do you have?");
        string percent = Console.ReadLine();
        int percentInt = int.Parse(percent);
        if (percentInt > 90 || percentInt == 90)
        {
            //Console.WriteLine($"{percent} --> A");
            letter = "A";
        }
        else if (percentInt >80 || percentInt == 80)
        {
            //Console.WriteLine($"{percent} --> B");
            letter = "B";
        }
        else if (percentInt >70 || percentInt == 70)
        {
            //Console.WriteLine($"{percent} --> C");
            letter = "C";
        }
        else if (percentInt >60 || percentInt == 60)
        {
            //Console.WriteLine($"{percent} --> D");
            letter = "D";
        }
        else
        {
            //Console.WriteLine($"{percent} --> F");
            letter = "F";
        }
        Console.WriteLine($"Your grade is {letter}");

        if(letter == "F" || letter == "D")
        {
            Console.WriteLine("You failed. Must have a C or greater to pass");
        }        
        else
        {
            Console.WriteLine("You passed with a C or higher!");
        }
    }
}