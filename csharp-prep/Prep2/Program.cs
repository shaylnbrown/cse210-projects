using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What was your grade percentage? ");
        int intGrade = int.Parse(Console.ReadLine());
        string letter="";
        if (intGrade >= 90) letter = "A";
        else if (intGrade >= 80 && intGrade < 90) letter = "B";
        else if (intGrade >= 70 && intGrade < 80) letter = "C";
        else if (intGrade >= 60 && intGrade < 70) letter = "D";
        else if (intGrade < 60) letter = "F";

        if (letter == "A" || letter == "F") Console.Write($"You earned an {letter}.");
        else Console.Write($" You earned a {letter}.");

        if (intGrade >= 70) Console.Write("Congradulations on passing the course.");
        else Console.Write(" I'm sure you will do better next time.");
    }
}