using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foundation3
{
    public class Event
    {
        protected string _type="";
        protected string _title="";
        protected string _description="";
        protected string _date="";
        protected string _time="";
        protected Address _address;

        public Event(string type, string title, string description, string date, string time, string streetAddress, string city, string state, int zipCode)
        {
            _type = type;
            _title = title;
            _description = description;
            _date = date;
            _time = time;
            _address = new Address(streetAddress, city, state, zipCode);
        }

        public string GetStandardDetails()
        {
            return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress:\n{_address.GetAddress()}";
        }

        public string GetShortDescription()
        {
            return $"Type: {_type}\nTitle {_title}\nDate: {_date}";
        }

    }
}