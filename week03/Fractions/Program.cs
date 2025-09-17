using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        Console.WriteLine($"Getter/Setter");
        Console.WriteLine($"Top: {fraction.GetTop()}");
        Console.WriteLine($"Bottom: {fraction.GetBottom()}");
        fraction.SetTop(10);
        fraction.SetBottom(50);
        Console.WriteLine($"Top Now: {fraction.GetTop()}");
        Console.WriteLine($"Bottom Now: {fraction.GetBottom()}");

        Console.WriteLine($"Fractions");
        Fraction fraction1 = new Fraction();
        Console.WriteLine($"{fraction1.GetFractionString()}");
        Console.WriteLine($"{fraction1.GetDecimalValue()}");

        Fraction fraction2 = new Fraction(5);
        Console.WriteLine($"{fraction2.GetFractionString()}");
        Console.WriteLine($"{fraction2.GetDecimalValue()}");


        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine($"{fraction3.GetFractionString()}");
        Console.WriteLine($"{fraction3.GetDecimalValue()}");

        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine($"{fraction4.GetFractionString()}");
        Console.WriteLine($"{fraction4.GetDecimalValue()}");
    }
}