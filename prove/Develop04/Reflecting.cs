using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop04
{
    public class Reflecting : Activity
    {

        public void RunActivity()
        {
            _activityName="Reflecting"; 
            _activityDescription="This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";           
            GetDuration(); 

            //Gets Prompts and Questions
            string[] lines=System.IO.File.ReadAllLines("ReflectionPrompts.txt");
            List<string> prompts=new List<string>();
            int count = 1;
            while (count<lines.Length && lines[count] != "Questions:")
            {
                prompts.Add(lines[count]);
                count++;
            }
            count++;
            List<string> questions=new List<string>();
            while (count<lines.Length)
            {
                questions.Add(lines[count]);
                count++;
            }

            Random random=new Random();
            string prompt = prompts[random.Next(0,prompts.Count-1)];
            int index = 0;

            CountDown("Get Ready:",5);
            Console.WriteLine();
            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine($"--- {prompt} ---");
            Console.WriteLine("When you have something in mind, press enter to continue.");
            string answer=Console.ReadLine();
            if (answer == "") {
                Console.WriteLine("Now ponder on each of the following questions as they relate to this experience");
                CountDown("You may begin in:",5); 
                Console.WriteLine();               
            }            
            DateTime end=DateTime.Now.AddSeconds(_duration);
            while (questions.Count > 0 && DateTime.Now < end)
            {
                index = random.Next(0,questions.Count-1);
                CountDown(questions[index],10);
                Console.WriteLine();
                questions.RemoveAt(index);
            }

            



            Congradulate();
        }                 

        
    }
}