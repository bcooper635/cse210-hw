using System;

class Program
{
    static void Main(string[] args)
    {
       Fraction Fraction1 = new();
       Fraction1.SetTop(1);
       Fraction1.SetBottom(1);
       Console.WriteLine(Fraction1.GetDecimalValue());
       Console.WriteLine(Fraction1.GetFractionString());

       Fraction1.SetTop(5);
       Fraction1.SetBottom(1);
       Console.WriteLine(Fraction1.GetDecimalValue());
       Console.WriteLine(Fraction1.GetFractionString());

       Fraction1.SetTop(3);
       Fraction1.SetBottom(4);
       Console.WriteLine(Fraction1.GetDecimalValue());
       Console.WriteLine(Fraction1.GetFractionString());

       Fraction1.SetTop(1);
       Fraction1.SetBottom(3);
       Console.WriteLine(Fraction1.GetDecimalValue());
       Console.WriteLine(Fraction1.GetFractionString());

    }
}