using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Quic;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        //exceeding requirements by giving the the user the option to choose from multiple scriptures. They can choose from
        //5 different scriptures, and for each one it will initialize an object from the scripture and reference classes.
        //then my program continues to run normally, displaying the scripture, and iterating through the words by randomly hiding 3 of them
        int foreverloop = 1;
        while(foreverloop == 1)
        {
        int validation = 1;
        string choice;
        Reference reference;
        Scripture script1;
        Console.WriteLine("Enter a number into the console to choose one of the following scriptures(or 'quit' to exit program): ");
        Console.WriteLine("1. James   1:5-6\n2. Alma    7:11-12\n3. Ether   12:27\n4. Ether   12:4\n5. 1 Nephi 20:10");
        string userChoice = Console.ReadLine();
        if (userChoice == "quit")
        {
            Console.WriteLine("Exiting program");
            break;
        }
        int userInt = int.Parse(userChoice);
        if (userInt == 1)
        {
        string scripture1 = "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him.";
        string scripture2 = " But let him ask in faith, nothing wavering. For he that wavereth is like a wave of the sea driven with the wind and tossed.";
        
        
        reference = new Reference("James",1,5,6);
        script1 = new Scripture(reference,scripture1+" " + scripture2);
        }
        else if (userInt == 2)
        {
        string scripture1 = "And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people.";
        string scripture2 = "And he will take upon him death, that he may loose the bands of death which bind his people; and he will take upon him their infirmities, that his bowels may be filled with mercy, according to the flesh, that he may know according to the flesh how to succor his people according to their infirmities.";
        
        
        reference = new Reference("Alma",7,11,12);
        script1 = new Scripture(reference,scripture1+" " + scripture2);
        }
        else if (userInt == 3)
        {
        string scripture1 = "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.";
        
        reference = new Reference("Ether",12,27);
        script1 = new Scripture(reference,scripture1);
        }
        else if (userInt == 4)
        {
        string scripture1 = "Wherefore, whoso believeth in God might with surety hope for a better world, yea, even a place at the right hand of God, which hope cometh of faith, maketh an anchor to the souls of men, which would make them sure and steadfast, always abounding in good works, being led to glorify God.";
        reference = new Reference("Ether",12,4);
        script1 = new Scripture(reference,scripture1);
        }
        else if (userInt == 5)
        {
        string scripture1 = "For, behold, I have refined thee, I have chosen thee in the furnace of affliction.";
        reference = new Reference("1 Nephi",20,10);
        script1 = new Scripture(reference,scripture1);
        }
        else
        {
        Console.WriteLine("Invalid entry. Choosing James 1:5-6 for you !");
        
        string scripture1 = "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him.";
        string scripture2 = " But let him ask in faith, nothing wavering. For he that wavereth is like a wave of the sea driven with the wind and tossed.";
        
        
        reference = new Reference("James",1,5,6);
        script1 = new Scripture(reference,scripture1+" " + scripture2);
        }
        


        while(validation ==1)
        {
     
        Console.Clear();
        Console.WriteLine(script1.GetDisplayText());
        Console.WriteLine("\n-Type quit or press enter to hide some words");

        choice = Console.ReadLine();
        if (choice == "quit" || choice == "Quit" || choice == "QUIT")
        {
            Console.Write("Input accepted, quitting scripture . . .\n");
            validation = 0;
        }
        else 
        {
            script1.HideRandomWords(3);
        }
       
       if (script1.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(script1.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Now exiting scripture.");
                validation = 0;
                
            }

        }
        }
    }
}