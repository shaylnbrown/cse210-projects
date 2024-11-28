using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning02
{
    public class Job
    {
        public string _company="";
        public string _jobTitle="";
        public int _startYear=0;
        public int _endYear=0;

        public void DisplayJob()
        {
            string dateRange=_startYear + "-";
            if (_endYear == 0) dateRange += "Present";
            else dateRange += _endYear;
            Console.WriteLine($"{_jobTitle} ({_company}) {dateRange}");
        }
    }
}