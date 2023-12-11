using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foundation2
{
    public class Customer
    {
        string _name="";
        Address _address;

        public Customer(string name, string streetAddress, string city, string state, string country)
        {
            _name = name;
            _address = new Address(streetAddress, city, state, country);
        }

        public string GetShippingLabel()
        {
            return _name + "\n" + _address.DisplayAddress();
        }

        public bool IsUSA()
        {            
            return _address.IsUSA();
        }


    }
}