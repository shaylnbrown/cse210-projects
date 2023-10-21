using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning03
{
    public class Fraction
    {
        private int _top=0;
        private int _bottum=0;

        public Fraction()
        {
            _top = 1;
            _bottum = 1;
        }

        public Fraction(int top)
        {
            _top = top;
            _bottum = 1;
        }

        public Fraction(int top, int bottum)
        {
            _top = top;
            _bottum = bottum;
        }

        public int GetTopNumber()
        {
            return _top;
        }

        public int GetBottumNumber()
        {
            return _bottum;
        }

        public void SetTopNumber(int top)
        {
            _top = top;
        }

        public void SetBottumNumber(int bottum)
        {
            _top = bottum;
        }

        public string GetFractionString()
        {
            return $"{_top}/{_bottum}";
        }

        public double GetDecimalValue()
        {
            return (double)_top/(double)_bottum;            
        }

    }
}