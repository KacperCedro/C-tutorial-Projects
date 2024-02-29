using Inheritance.Classes;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shapes firstSquare = new Square(4);
            Shapes firstRectangle = new Rectangle(3, 6);
            Shapes firstCircle = new Circle(7);

            Console.WriteLine($"Square data: {firstSquare.Area()} ; {firstSquare.Perimeter()}");
            Console.WriteLine($"Square data: {firstRectangle.Area()} ; {firstRectangle.Perimeter()}");
            Console.WriteLine($"Square data: {firstCircle.Area()} ; {firstCircle.Perimeter()}");

        }
    }
}