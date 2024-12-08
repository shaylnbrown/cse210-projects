using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foundation4
{
    public class Running : Activity
    {
        int _distance = 0;

        public Running(string type, string date, double duration, int distance) : base(type, date, duration)
        {
            _distance = distance;
        }

        override public double GetDistance()
        {
            return _distance;
        }

        override public double GetSpeed()
        {
            return _distance/_duration;
        }      

        

        
    }
}