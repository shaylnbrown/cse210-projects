using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop04
{
    public class Listing : Activity
    {
        public void RunActivity()
        {
            _activityName="Listing"; 
            _activityDescription="This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
            GetDuration();

            //Gets Prompts
            string[] lines=System.IO.File.ReadAllLines("ListingPrompts.txt");
            List<string> prompts=new List<string>();
            int count = 1;
            while (count<lines.Length && lines[count] != "Questions:")
            {
                prompts.Add(lines[count]);
                count++;
            }
            Random random=new Random();
            string prompt = prompts[random.Next(0,prompts.Count-1)];
            string response="";

            Console.WriteLine("List as many reponses you can to the following prompt:");
            Console.WriteLine($"--- {prompt} ---");
            CountDown("You may begin in:",5);
            Console.WriteLine();
            count = 0;
            DateTime end=DateTime.Now.AddSeconds(_duration);
            while (DateTime.Now < end)
            {
                //Console.WriteLine("> ");                
                response = Console.ReadLine().ToString();
                if (response!="") count++;
            }
            Console.WriteLine($"You listed {count} items!");

            Congradulate(); 
        }
        
    }
}