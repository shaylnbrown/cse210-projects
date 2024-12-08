using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning05
{
    public class Rect : Shape
    {
        double _length = 0;
        double _width = 0;

        public Rect(string color, double width, double length) : base(color)
        {
            _length = length;
            _width = width;
            _color = color;
        }

        public override double GetArea()
        {
            return _width * _length;
        }
    }
}