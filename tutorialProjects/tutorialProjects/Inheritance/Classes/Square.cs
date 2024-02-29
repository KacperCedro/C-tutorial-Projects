using Inheritance.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Classes
{
    internal class Square : Shapes, ISquareShapes
    {
        public double A { get ; set; }
        public double B { get ; set; }

        public Square(double a)
        {
            A = a;
        }
        public override double Area()
        {
            return A * A;
        }

        public override double Perimeter()
        {
            return 4 * A;
        }
    }
}
