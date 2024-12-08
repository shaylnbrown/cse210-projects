using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foundation3
{
    public class Address
    {
        string _streetAddress="";
        string _city="";
        string _state="";
        int _zipCode=0;
        public Address(string streetAddress, string city, string state, int zipCode)
        {
            _streetAddress = streetAddress;
            _city = city;
            _state = state;
            _zipCode = zipCode;
        }

        public string GetAddress()
        {
            return $"{_streetAddress}\n{_city}, {_state} {_zipCode}";

        }
    }
}