using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        string strUsername = PromptUserName();
        int intNumber = PromptUserNumber();
        intNumber = SquareNumber(intNumber);
        DisplayResult(strUsername,intNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string strUserName = Console.ReadLine();
        return strUserName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int intUserNumber = int.Parse(Console.ReadLine());
        return intUserNumber;
    }
    static int SquareNumber(int intRoot)
    {        
        return intRoot*intRoot;
    }

    static void DisplayResult(string strName, int intSquared)
    {
        Console.WriteLine(strName + ", the square of your number is " + intSquared.ToString());
    }
}