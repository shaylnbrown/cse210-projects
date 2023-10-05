using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning02
{
    public class Resume
    {
        public string _fullName="";
        public List<Job> _jobList = new List<Job>();

        public void DisplayResume()
        {
            Console.WriteLine(_fullName);
            int intCount=0;
            while (intCount < _jobList.Count)
            {
                _jobList[intCount].DisplayJob();
                intCount++;
            }
        }

    }

    
}