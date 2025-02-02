using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Random randomGenerator = new Random();
        int intAnswer = randomGenerator.Next(1, 100);
        int intGuess = -999;  
        int count = 0;
        while (intGuess != intAnswer)
        {
            Console.Write("Guess a number between 1 and 100: ");
            intGuess = int.Parse(Console.ReadLine());
            if (intGuess > intAnswer) Console.Write("The correct number is lower. ");
            if (intGuess < intAnswer) Console.Write("The correct number is higher. ");
            count++;
        }  
        if (count <= 10) Console.Write($"{count} tries! Nailed it!");
        if (count > 10 && count <= 20) Console.Write($"{count} tries. Good job!");
        if (count > 20) Console.Write($"{count} tries. Positively Sufficient.");
    }
}