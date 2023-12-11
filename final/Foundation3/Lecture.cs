using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foundation3
{
    public class Lecture : Event
    {
        string _speaker="";
        int _capacity=0;
        public Lecture(string type, string title, string description, string date, string time, string streetAddress, string city, string state, int zipCode, string speaker, int capacity): base(type, title, description, date, time, streetAddress, city, state, zipCode)
        {
            _speaker = speaker;
            _capacity = capacity;
        }
    }
}