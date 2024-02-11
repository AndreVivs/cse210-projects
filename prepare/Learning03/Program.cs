using System;

class Program
{
    static void Main(string[] args)
    {

        Fraction f1 = new Fraction();

        Console.WriteLine("Option 1");
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
        Console.WriteLine("");


        Console.WriteLine("Option 2");
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
        Console.WriteLine("");

        Console.WriteLine("Option 3");
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
        Console.WriteLine("");

        Console.WriteLine("Option 4");
        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
        Console.WriteLine("");

        /*
        Fraction fraction1 = new Fraction();
        fraction1.SetTop(1);
        fraction1.SetBottom(1);

        Console.WriteLine($"{fraction1.GetTop()}/{fraction1.GetBottom()}");

        Fraction fraction2 = new Fraction(int top);
        int top = 5

        Fraction fraction3 = new Fraction(int top, int bottom);
        int top = 5
        int bottom = 3
        */


    }
}