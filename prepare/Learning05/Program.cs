using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        Assignment AS1 = new("Blake Cooper","Division");
        Console.WriteLine(AS1.GetSummary());

        MathAssignment AS2 = new("Blake Cooper","Feedback Control","4.3","46-49");
        Console.WriteLine(AS2.GetHomeworkList());

        WritingAssignment AS3 = new("Blake Cooper","Literature","Homelessness in Australia by Blake Cooper");
        Console.WriteLine(AS3.GetWritingInformation());
    }
}