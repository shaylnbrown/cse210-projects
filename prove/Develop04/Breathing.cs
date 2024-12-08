using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop04
{
    public class Breathing : Activity
    {
        

        public void RunActivity()
        {
            _activityName="Breathing"; 
            _activityDescription="This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";           
            GetDuration();            
            int prepTime=_duration % 10;
            if (prepTime < 5) prepTime = 5;
            CountDown("Get Ready:",prepTime);
            int counter = 0;
            while (counter < _duration / 10)
            {
                Console.WriteLine();
                Console.WriteLine();
                CountDown("Breath in", 4);
                Console.WriteLine();
                CountDown("Now breath out", 6);
                counter++;
            }
            Congradulate();     
            
        }        
    }
}