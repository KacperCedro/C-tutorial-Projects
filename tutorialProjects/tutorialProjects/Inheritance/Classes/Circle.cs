using Inheritance.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Classes
{
    internal class Circle : Shapes, IRoundShapes
    {
        public double R { get; set ; }
        public Circle(double r)
        {
            R = r;
        }
        public override double Area()
        {
            return Math.PI * (R * R) ; 
        }
        public override double Perimeter()
        {
            return 2 * Math.PI * R; 
        }
    }
}
