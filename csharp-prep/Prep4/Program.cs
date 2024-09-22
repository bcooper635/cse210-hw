using System;

class Program
{
    static void Main(string[] args)
    {
        List<double> words = new List<double>();
        Console.WriteLine("Enter a list of numbers, type 0 when completed.");
        Console.WriteLine("Enter a number: ");
        string userInput = Console.ReadLine();
        double userInt = double.Parse(userInput);
        while(userInt != 0)
        {
            words.Add(userInt);
            Console.WriteLine("Enter a number: ");
            userInput = Console.ReadLine();
            userInt = double.Parse(userInput);
           
        }
        double greatest = words[0];
        double least = words[0];
        double total = 0;
        for (int i = 0; i<words.Count; i++)
        {
            if (words[i] > greatest)
            {greatest = words[i];}
            if (words[i] < least)
            {least = words[i];}
            total = total + words[i];
    
        }
        double avg = total/words.Count;
        Console.WriteLine($"\nTotal: {total} \nAverage: {avg}\nMaximum: {greatest}\nMinimum: {least} ");
    }
}