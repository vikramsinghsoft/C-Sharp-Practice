using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public abstract class Figure
    {
        public double Width, Height, Radius;
        public const float Pi = 3.14f;

        public abstract double GetArea();
    }

    public class Rectangle : Figure
    {
        public Rectangle(double Width, double Hieght)
        {
            this.Width = Width;
            this.Height = Hieght;
        }
        public override double GetArea()
        {
            return Width * Height; 
        }
    }
    public class Circle:Figure
    {
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }
        public override double GetArea()
        {
            return Pi * Radius * Radius;
        }
    }
    public class Cone:Figure
    {
        public Cone(double Radius,double Height)
        {
            this.Radius = Radius;
            this.Height = Height;
        }
        public override double GetArea()
        {
            return Pi * Radius*(Radius + Math.Sqrt(Height * Height + Radius * Radius));
        }
    }

    class TestFigure
    {
        static void Main()
        {
            Rectangle r = new Rectangle(10, 10);
            Circle ci = new Circle(45.67);
            Cone co = new Cone(34.22, 20.21);

            Console.WriteLine("Area of Rectangle : " + r.GetArea());
            Console.WriteLine("Area of Circle : " + ci.GetArea());
            Console.WriteLine("Area of Cone : " + co.GetArea());

            Console.ReadLine();
        }
    }
}
