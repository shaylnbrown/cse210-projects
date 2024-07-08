using System;
using Develop05;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello Develop05 World!");        
        int totalPoints = 0;
        List<SimpleGoal> goalList = new List<SimpleGoal>();
        string type = "";
        string[] goalLines =  new string[0];
        int goalNumber = 0;
        string goalFile="";
        
        int menuSelection=0;
        int subMenuSelection=0;
        while (menuSelection != 6)
        {
            //Console.Clear();
            Console.WriteLine();
            menuSelection = GetMenuSelection(totalPoints);
            Console.WriteLine();
            if (menuSelection == 1)
            {
                subMenuSelection=GetGoalType();
                if (subMenuSelection==1) goalList.Add(new SimpleGoal());
                if (subMenuSelection==2) goalList.Add(new EternalGoal());
                if (subMenuSelection==3) goalList.Add(new ChecklistGoal());
            } 

            if (menuSelection == 2)
            {
                Console.WriteLine(DisplayAllGoals(goalList));                
            }           

            if (menuSelection == 3)
            {
                Console.Write("What is the filename for the goal file? ");
                goalFile = Console.ReadLine();                
                using (StreamWriter outputFile = new StreamWriter(goalFile))
                {
                    foreach (SimpleGoal goal in goalList) outputFile.WriteLine(goal.SaveGoal());
                }
                
            }   

            if (menuSelection == 4)
            {
                goalList.Clear();
                Console.Write("What is the filename for the goal file? ");
                goalFile = Console.ReadLine();
                goalLines = System.IO.File.ReadAllLines(goalFile);                
                foreach (string line in goalLines)
                {
                    type = line.Split('|')[0];
                    if (type == "SimpleGoal") goalList.Add(new SimpleGoal(line));
                    if (type == "EternalGoal") goalList.Add(new EternalGoal(line));
                    if (type == "ChecklistGoal") goalList.Add(new ChecklistGoal(line));
                }
                totalPoints = TallyPoints(goalList);                
                Console.WriteLine($"{goalLines.Length} goals have been loaded.");
            }    

            if (menuSelection == 5)
            {
                Console.WriteLine(DisplayAllGoals(goalList));
                Console.WriteLine("Which goal did you make progress on?");
                goalNumber = int.Parse(Console.ReadLine());
                Console.WriteLine();
                goalList[goalNumber-1].UpdateGoal();                
                totalPoints = TallyPoints(goalList);
            }    
        }
    }

    static private int GetGoalType()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        return int.Parse(Console.ReadLine());
    }

    static private int GetMenuSelection(int total)
    {
        
        Console.WriteLine($"You have {total} points");
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Quit");        
        return int.Parse(Console.ReadLine());        
    }

    static private string DisplayAllGoals(List<SimpleGoal> goalsToDisplay)
    {        
        string output = "";
        int index = 0;
        while (index < goalsToDisplay.Count)
        {
            if (output != "") output += "\n";
            output += $"{index + 1}. {goalsToDisplay[index].DisplayGoal()}";
            index++;
        } 

        if (output == "") output = "There are no goals yet.";

        return output;
    }

    static private int TallyPoints(List<SimpleGoal> goalsToTally)
    {
        int tally = 0;
        foreach (SimpleGoal goal in goalsToTally) tally += goal.GetTally();
        return tally;
    }
}