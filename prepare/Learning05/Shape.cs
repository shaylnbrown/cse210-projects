using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning05
{
    public class Shape
    {
        protected string _color="";

        public Shape(string color)
        {

        }

        public string GetColor()
        {
            return _color;
        }

        public void SetColor(string color)
        {
            _color = color;
        }

        public virtual double GetArea()
        {
            return 0;
        }
    }
}