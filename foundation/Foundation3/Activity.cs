using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foundation4
{
    public class Activity
    {
        protected string _date = "";
        protected double _duration = 0;

        protected string _type="";

        public Activity(string type, string date, double duration)
        {
            _type = type;
            _date = date;
            _duration = duration/60;
        }

        virtual public double GetDistance()
        {
            return 0;
        }

        virtual public double GetSpeed()
        {
            return 0;
        }

        public double GetPace()
        {
            return GetSpeed()/60;
        }

        public string GetSummary()
        {
            return $"{_date} {_type} ({_duration*60} min): Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {Math.Round(GetPace(),2)} min/km";
        }
        



    }


}