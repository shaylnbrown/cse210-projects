using System;
using Develop04;
using System.IO;

class Program
{

    static public void DisplayJournal(List<JournalEntry> entryListOUT)
    {
        string date="";
        foreach (JournalEntry entry in entryListOUT)
        {
            date=entry._date.ToString("M/d/yyyy");            
            Console.WriteLine($"Date: {date} - Prompt: {entry._prompt}");
            Console.WriteLine(entry._answer);
            Console.WriteLine();
        }
    }
    static public void SaveJournal(List<JournalEntry> entryListOUT)
    {
        if (entryListOUT.Count == 0) return;
        Console.Write("What is the filename? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine("Date|Prompt|Response");
            foreach (JournalEntry entry in entryListOUT) outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._answer}");        
        }
        Console.WriteLine(entryListOUT.Count);
    }

    static public List<JournalEntry> LoadJournal()
    {
        List<JournalEntry> entryListIN = new List<JournalEntry>();
        Console.Write("What is the filename? ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] chunks = line.Split('|');
            if (chunks[0] != "Date")
            {
                JournalEntry newEntry = new JournalEntry();
                newEntry._date=Convert.ToDateTime(chunks[0]);
                newEntry._prompt=chunks[1];
                newEntry._answer=chunks[2];
                entryListIN.Add(newEntry);
            }
            
        }
        return entryListIN;
    }

    static public int GetMenuChoice()
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
        Console.WriteLine("Hello Develop02 World!");
        List<JournalEntry> entryList = new List<JournalEntry>();
        int choice = 0;
        while (choice != 5)
        {       
            if (choice == 1)
            {
                JournalEntry newEntry = new JournalEntry();
                newEntry.CreateEntry();
                entryList.Add(newEntry);
            }   
            if (choice == 2)
            {
                DisplayJournal(entryList);
            }     
            if (choice == 3)
            {
                entryList=LoadJournal();
            }
            if (choice == 4)
            {
                SaveJournal(entryList);
            }
            
            choice = GetMenuChoice();
        }
    }
}