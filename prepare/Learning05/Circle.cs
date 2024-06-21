using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning05
{
    public class Circle : Shape
    {
        double _radius = 0;

        public Circle(string color, double radius) : base(color)
        {
            _radius = radius;
            _color = color;
        }

        public override double GetArea()
        {
            return Math.PI*_radius*_radius;
        }

    }

    

}