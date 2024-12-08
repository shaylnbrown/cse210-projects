using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop05
{
    public class EternalGoal : SimpleGoal
    {
        int _stepPoints = 0;
        public EternalGoal()
        {
            //GetBasics();
            _stepPoints = _completionPoints;
        }

        public EternalGoal(string textLine) : base(textLine)
        {
            _stepPoints = _completionPoints;
        }

        public override string SaveGoal()
        {
            return "EternalGoal|" + _name + "|" + _description + "|" + _stepPoints + "|" + _completionTally;
        }

        public override string DisplayGoal()
        {
            string complete = " ";            
            return $"[{complete}] {_name} ({_description})";
        }

        public override void UpdateGoal()
        {            
            _completionTally += _stepPoints;
            Console.WriteLine($"Congradulations! You have earned {_stepPoints} points!");            
        }




    }
}