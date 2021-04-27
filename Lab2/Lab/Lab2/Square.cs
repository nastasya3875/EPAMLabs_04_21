using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Square : Figure
    {
        double a;
        public Square(double a)
        {
            this.a = a;
        }
        public override double Ploshad()
        {
            return a * a;
        }
        public override double Perimeter()
        {
            return a + a + a + a;
        }
    }
}
