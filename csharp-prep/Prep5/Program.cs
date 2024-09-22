using System;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        //Tasks:
        //Display Welcome
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to Prep5");
        }
        //Prompt User name
        static string UserName()
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            return name;
        }
        //Prompt User number
        static int UserNumber()
        {
            Console.WriteLine("Please enter your favorite number: ");
            string number = Console.ReadLine();
            int favNum = int.Parse(number);
            return favNum;
        }
        //Square number
        static int SquareNumber(int num)
        {
            int square = num*num;
            return square;
        }
        static void DisplayResult(int square, string name)
        {
            Console.WriteLine($"{name}, the square of your favorite number is {square}");
        }
        //Display result

        DisplayWelcome();
        string name = UserName();
        int num = UserNumber();
        int square = SquareNumber(num);
        DisplayResult(square, name);






    }
}