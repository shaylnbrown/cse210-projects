using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop04
{
    public class Prompt
    {   
        static public string GetRandomPrompt()
        {
            string filename = "PromptList.txt";
            string[] lines = System.IO.File.ReadAllLines(filename);
            Random rnd = new Random();
            int promptIndex = rnd.Next(0,lines.Length);
            return lines[promptIndex];
        }
    }
}