using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foundation3
{
    public class Reception : Event
    {        
        int _RSVPs=0;
        public Reception(string type, string title, string description, string date, string time, string streetAddress, string city, string state, int zipCode, int RSVPs): base(type, title, description, date, time, streetAddress, city, state, zipCode)
        {            
            _RSVPs = RSVPs;
        }
    }
}