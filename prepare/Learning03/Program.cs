using System;
using Learning03;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6,7);

        Fraction fraction4=new Fraction();
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());

        Fraction fraction5=new Fraction(5);
        Console.WriteLine(fraction5.GetFractionString());
        Console.WriteLine(fraction5.GetDecimalValue());

        Fraction fraction6=new Fraction(3,4);
        Console.WriteLine(fraction6.GetFractionString());
        Console.WriteLine(fraction6.GetDecimalValue());

        Fraction fraction7=new Fraction(1,3);
        Console.WriteLine(fraction7.GetFractionString());
        Console.WriteLine(fraction7.GetDecimalValue());


    }
}