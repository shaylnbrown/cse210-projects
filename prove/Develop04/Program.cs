using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using Develop04;

public class Program
{
    
    public int GetMenuChoice()
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do? ");
        return int.Parse(Console.ReadLine());
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        int choice = 0;
        while (choice != 5)
        {       
            
            //choice = getmen
        }
    }

    
}