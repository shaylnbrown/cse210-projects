using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foundation3
{
    public class Reception : Event
    {        
        
        string _email="";
        public Reception(string type, string title, string description, string date, string time, string streetAddress, string city, string state, int zipCode, string email): base(type, title, description, date, time, streetAddress, city, state, zipCode)
        {            
            _email = email;
        }

        public string GetFullDetails()
        {
            return $"Event type: {_type}\n{GetStandardDetails()}\nRSVP Email: {_email}";
        }
    }
}