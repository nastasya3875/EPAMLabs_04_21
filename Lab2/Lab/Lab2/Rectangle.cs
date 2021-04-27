using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Rectangle : Figure
    {
        double a, b;
        public int number { get; set; }
        public string color { get; set; }
        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public override double Ploshad()
        {
            return a * b;
        }
        public override double Perimeter()
        {
            return (a + b) * 2;
        }
    }
}
