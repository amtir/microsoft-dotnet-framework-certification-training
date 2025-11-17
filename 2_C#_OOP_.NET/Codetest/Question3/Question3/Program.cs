using System;

namespace Question3
{
    class Shapes
    {
        public double AreaOfRectangle(double length, double breadth)
        {
            return length * breadth;
        }
        public double AreaOfCircle(double radius)
        {
            return Math.PI * radius * radius;
        }
        public double AreaOfSquare(double side)
        {
            return side * side;
        }
        public double AreaOfTriangle(double b, double h)
        {
            return 0.5 * b * h;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shapes shape = new Shapes();

            Console.WriteLine("Enter the Length for Rectangle:");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Breadth for Rectangle:");
            double breadth = Convert.ToDouble(Console.ReadLine());

            double rectArea = shape.AreaOfRectangle(length, breadth);
            Console.WriteLine($"Area of rectangle is : {rectArea}");

            Console.ReadLine();
        }
    }
}
