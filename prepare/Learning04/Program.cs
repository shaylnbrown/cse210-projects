using System;
using Learning04;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Console.WriteLine("Step 3");
        Assignment test1 = new Assignment("Shay Brown", "Programming with Classes");
        Console.WriteLine(test1.GetSummary());
        Console.WriteLine("Step 4");
        MathAssignment test2 = new MathAssignment("Shay Brown", "Programming with Classes","7.3","8-19");
        Console.WriteLine(test2.GetSummary());
        Console.WriteLine(test2.GetHomeworkList());
        Console.WriteLine("Step 5");
        WritingAssignment test3 = new WritingAssignment("Shay Brown", "Programming with Classes","Magical Me");
        Console.WriteLine(test3.GetSummary());
        Console.WriteLine(test3.GetWritingInformation());
    }
}