using System;
using System.Linq.Expressions;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning06 World!");

        Square S1 = new(5,"Blue");
        Rectangle R1 = new(10,5,"Green");
        Circle C1 = new(4,"Red");
        
        Console.WriteLine("Color: "+S1.GetColor()+"\nArea: "+S1.GetArea());
        Console.WriteLine("Color: "+R1.GetColor()+"\nArea: "+R1.GetArea());
        Console.WriteLine("Color: "+C1.GetColor()+"\nArea: "+C1.GetArea());
        

 
    }
}