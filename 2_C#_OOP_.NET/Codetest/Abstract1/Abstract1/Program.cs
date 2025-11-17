using System;

namespace Abstract1
{
    public abstract class Shape
    {
        public abstract void draw();
        public void display() {
            Console.WriteLine("I am a concrete method inside an abstract class");
        }
    }

    public class Circle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing circle ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract ...");
            Circle c = new Circle();
            c.draw();
            c.display();
        }
    }
}
