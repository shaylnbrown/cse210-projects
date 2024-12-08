using System;
using Develop03;

class Program
{

    
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Scripture scripture=new Scripture();
        List<string> wordList=scripture.getWordList();
        string response="";
        
        Console.WriteLine();
        Console.WriteLine(scripture.GetScriptureText());
        Console.WriteLine();
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        response=Console.ReadLine();

        int wordIndex=0;
        Random rnd=new Random();
        
        while (response != "quit" && wordList.Count>0)
        {
            wordIndex=rnd.Next(0,wordList.Count);
            scripture.BlankWord(wordList[wordIndex]);
            wordList.RemoveAt(wordIndex);
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(scripture.GetScriptureText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            response=Console.ReadLine();
        }
        
        //
    }

    


}