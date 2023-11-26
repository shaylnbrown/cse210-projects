using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop05
{
    public class ChecklistGoal : SimpleGoal
    {
        int _completionBonus = 0;
        int _stepPoints = 0;
        int _stepTotal=0;        


        public ChecklistGoal()
        {
            _stepPoints = _completionPoints;
            Console.WriteLine("How many time doe sthis goal need to be completed for a bonus? ");
            _stepTotal = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the bonus for accomplishing it that many times? ");
            _completionBonus = int.Parse(Console.ReadLine());
        }

        public ChecklistGoal(string textLine) : base(textLine)
        {
            _stepPoints = _completionPoints;
            string[] chunks = textLine.Split('|');
            _stepTotal=int.Parse(chunks[5]);
            _completionBonus=int.Parse(chunks[6]);
        }

        public override string SaveGoal()
        {
            return "SimpleGoal|" + _name + "|" + _description + "|" + _stepPoints + "|" + _completionTally + "|" + _stepTotal + "|" + _completionBonus;
        }

        public override string DisplayGoal()
        {
            string complete = " ";
            if (_completionTally >= (_stepPoints * _stepTotal)) complete = "X";
            int soFar = _completionTally/_stepPoints;
            if (soFar > _stepTotal) soFar = _stepTotal;
            return $"[{complete}] {_name} ({_description}) -- Currently Completed: {soFar}/{_stepTotal}";
        }

        public override void UpdateGoal()
        {
            if (_completionTally >= (_completionPoints * _stepTotal)) Console.WriteLine("You have already accomplished this goal.");
            else 
            {
                _completionTally += _stepPoints;
                if (_completionTally == (_completionPoints * _stepTotal))
                {
                    _completionTally += _completionBonus;
                    Console.WriteLine($"Congradulations! You have earned {_completionPoints} points for completing this goal plus a {_completionBonus} point bonus!");
                }
                else
                {
                    Console.WriteLine($"Congradulations! You have earned {_stepPoints} points!");
                }                
            }
        }


    }
}