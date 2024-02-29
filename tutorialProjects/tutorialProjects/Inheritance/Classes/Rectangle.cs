using Inheritance.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Classes
{
    internal class Rectangle : Shapes, ISquareShapes
    {
        public double A { get ; set ; }
        public double B { get ; set ; }
        public Rectangle(double a, double b)
        {
            A = a;
            B = b;
        }
        public override double Area()
        {
            return A * B;
        }

        public override double Perimeter()
        {
            return (2 * A) + (2 * B);
        }
    }
}
