using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foundation4
{
    public class Cycling : Activity
    {
        double _speed = 0;

        public Cycling(string type, string date, double duration, double speed) : base(type, date, duration)
        {            
            //Speed is in kph
            _speed = speed;
        }

        override public double GetDistance()
        {
            return _speed * _duration;
        }

        override public double GetSpeed()
        {
            return _speed;
        }   

    }
}