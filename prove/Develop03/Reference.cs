using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop03
{
    public class Reference
    {
        private string _reference="";
        public Reference(string[] lines)
        {
            _reference=lines[0];
        }

        public string GetReferenceText()
        {
            return _reference;
        }
        
    }
}