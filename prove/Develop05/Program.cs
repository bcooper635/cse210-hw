using System;
using System.ComponentModel.Design.Serialization;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {

        //Used creativity to exceed core requirements in the reflection class. I added functionality to make sure that the program
        //does not ask the same question twice, unless every question has been asked already, which will only occur
        //if the user entered a duration that is long enough to ask every single question.  
        while(true)
        {
        BreathingActivity B1 = new("Breathing Activity","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        ListingActivity L1 = new("Listing Activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        ReflectionActivity R1 = new("Reflection Activity","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("   1. Start Breathing Activity\n   2. Start Reflecting Activity\n   3. Start Listing Activity\n   4. Quit");
        Console.WriteLine("Select a choice from the menu: ");
        string _stringChoice = Console.ReadLine();
        int _intChoice = int.Parse(_stringChoice);
        if (_intChoice == 1) {
            B1.DisplayStartingMessage();
            B1.Run();
            B1.DisplayEndingMessage(); }
        else if(_intChoice == 2){
            R1.DisplayStartingMessage();
            R1.Run();
            R1.DisplayEndingMessage();
        }
        else if (_intChoice == 3){
            L1.DisplayStartingMessage();
            L1.Run();
            L1.DisplayEndingMessage();
        }
        else if (_intChoice == 4)
            break;
        else
        Console.WriteLine("Invalid Entry, try again.\n");
        }
    }
}