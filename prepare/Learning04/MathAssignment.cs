using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Learning04
{
    public class MathAssignment : Assignment
    {
        private string _textbookSection = "";
        private string _problems = "";

        public MathAssignment(string name, string topic, string section, string problems) : base(name,topic)
        {
            _textbookSection = section;
            _problems = problems;
        }

        public string GetHomeworkList()
        {
            return $"Section {_textbookSection} Problems {_problems}";
        }
    }
}