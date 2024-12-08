using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning05
{
    public class Square : Shape
    {

        double _side=0;
        public Square(string color, double side) : base(color)
        {
            _side = side;
            _color=color;
        }

        public override double GetArea()
        {
            return _side*_side;
            //return base.GetArea();
        }

    }
}