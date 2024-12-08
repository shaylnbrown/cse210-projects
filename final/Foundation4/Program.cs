using System;
using Foundation4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!" + "\n");
        List<Activity> activityList =  new List<Activity>();
        activityList.Add(new Cycling("Cycling", "12/12/23",120,20));
        Console.WriteLine(activityList[0].GetSummary() + "\n");
        activityList.Add(new Running("Running", "12/13/23",30,2));        
        Console.WriteLine(activityList[1].GetSummary() + "\n");
        activityList.Add(new Swimming("Swimming", "12/14/23",20,5));
        Console.WriteLine(activityList[2].GetSummary() + "\n");
    }
}