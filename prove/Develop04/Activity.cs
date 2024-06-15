using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop04
{
    public class Activity
    {

        protected string _activityName = "";
        protected string _activityDescription = "";
        protected int _duration=0;        

        protected void CountDown(string message, int duration)
        {        
            string display=$"{message} ";        
            int miliCount = (duration*1000);
            string wheel = "/";        
            
            while (miliCount > 0)
            {
                Console.Write($"\r{wheel} {display}");                
                if (wheel=="/") wheel="-";
                else if (wheel=="-") wheel=@"\";
                else if (wheel==@"\") wheel=@"|";
                else wheel="/";
                if (miliCount % 1000 != 0) display += ".";
                else display += miliCount/1000;                         
                Thread.Sleep(250);           
                miliCount-=250;
            }        
            Console.Write($"\r{display}");
        }

        protected void GetDuration()
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the {_activityName} Activity.");
            Console.WriteLine();
            Console.WriteLine(_activityDescription);
            Console.WriteLine();
            Console.Write("How long, in seconds, would you like for your session? ");
            _duration = int.Parse(Console.ReadLine());
        }

        protected void Congradulate()
        {
            Console.WriteLine();
            Console.WriteLine($"Well Done! You have completed another {_duration} seconds of {_activityName} activity!");
            CountDown("Now bask in your own success", 6);
        }
    }
}