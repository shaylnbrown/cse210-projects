using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foundation3
{
    public class OutdoorGathering : Event
    {
        string _weather="";
        public OutdoorGathering(string type, string title, string description, string date, string time, string streetAddress, string city, string state, int zipCode, string weather): base(type, title, description, date, time, streetAddress, city, state, zipCode)
        {            
            _weather = weather;
        }

        public string GetFullDetails()
        {
            return $"Event type: {_type}\n{GetStandardDetails()}\nWeather: {_weather}";
        }
    }
}