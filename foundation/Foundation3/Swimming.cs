using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foundation4
{
    public class Swimming : Activity
    {
        int _lapCount = 0;

        public Swimming(string type, string date, double duration, int lapCount) : base(type, date, duration)
        {
            _lapCount = lapCount;
        }

        override public double GetDistance()
        {
            return (double)(_lapCount * 50) / 1000;
        }

        override public double GetSpeed()
        {
            return GetDistance()/_duration;
        }       
       

    }
}