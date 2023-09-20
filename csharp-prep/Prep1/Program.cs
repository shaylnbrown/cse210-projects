using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        Console.Write("What is your first name? ");
        string strFirst = Console.ReadLine();
        Console.Write("What is your last name? ");
        string strLast = Console.ReadLine();
        Console.Write($"Your name is {strLast}, {strFirst} {strLast}.");
    }
}