using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> intList = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int intLargest = -999;
        int intTally = 0;
        int intCount = 0;
        int intNumber = -999;
        while (intNumber != 0)
        {
            Console.Write("Enter number: ");
            intNumber = int.Parse(Console.ReadLine());
            if (intNumber != 0)
            {
                if (intNumber > intLargest) intLargest = intNumber;
                intTally += intNumber;
                intCount++;
                intList.Add(intNumber);
            }            
        }
        Console.WriteLine("The sum is: " + intTally);
        double dblAverage = (double)(intTally/intCount);
        Console.WriteLine("The average is: " + dblAverage);
        Console.WriteLine("The largest number is: " + intLargest);
    }
}