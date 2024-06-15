using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using Develop04;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");        
        string answer="";
        while (answer != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.WriteLine("Select a choice from the menu:");
            answer = Console.ReadLine();
            if (answer=="1")
            {
                RunBreathing();
            }
            else if (answer=="2")
            {
                RunReflecting();
            }
            else if (answer=="3")
            {
                RunListing();
            }            
        }
        
    }

    static void RunBreathing()
    {
        Breathing breathing=new Breathing();
        breathing.RunActivity();
    }
    static void RunReflecting()
    {
        Reflecting reflecting=new Reflecting();
        reflecting.RunActivity();
    }
    static void RunListing()
    {
        Listing listing=new Listing();
        listing.RunActivity();
    }   
}