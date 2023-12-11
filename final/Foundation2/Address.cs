using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foundation2
{
    public class Address
    {
        string _streetAddress="";
        string _city="";
        string _state="";
        string _country="";
        
        public Address(string streetAddress, string city, string state, string country)
        {
            _streetAddress = streetAddress;
            _city = city;
            _state = state;
            country = _country;
        }

        public bool IsUSA()
        {            
            if (_country == "USA") return true;
            else return false;
        }

        public string DisplayAddress()
        {
            return _streetAddress + "\n" + $"{_city}, {_state}";
        }
        
        
        
        
    }
}