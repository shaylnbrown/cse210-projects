using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop05
{
    public class SimpleGoal
    {
        protected string _name="";
        protected string _description="";
        protected int _completionPoints=0;
        protected int _completionTally=0;

        public SimpleGoal()
        {
            GetBasics();
        }
        public SimpleGoal(string textLine)
        {
            string[] chunks=textLine.Split('|');
            _name = chunks[1];
            _description = chunks[2];
            _completionPoints = int.Parse(chunks[3]);
            _completionTally = int.Parse(chunks[4]);
        }

        protected void GetBasics()
        {
            Console.Write("What is the name of your goal? ");
            _name = Console.ReadLine();            
            Console.Write("What is a short description of it? ");
            _description = Console.ReadLine();            
            Console.Write("What is the amount of points associated with this goal? ");
            _completionPoints = int.Parse(Console.ReadLine());
            _completionTally = 0;
        }

        public virtual string SaveGoal()
        {
            return "SimpleGoal|" + _name + "|" + _description + "|" + _completionPoints + "|" + _completionTally;
        }

        public virtual string DisplayGoal()
        {
            string complete = " ";
            if (_completionTally == _completionPoints) complete = "X";
            return $"[{complete}] {_name} ({_description})";
        }

        public virtual void UpdateGoal()
        {
            if (_completionTally == _completionPoints) Console.WriteLine("You have already accomplished this goal.");
            else 
            {
                _completionTally = _completionPoints;
                Console.WriteLine($"Congradulations! You have completed this goal and earned {_completionTally} points!");
            }
        }

        public int GetTally()
        {
            return _completionTally;
        }

    }
}