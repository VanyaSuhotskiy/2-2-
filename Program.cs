using System;

namespace _2_лаба_2_задание
{
    class Rectangle
    {
        public double side1;
        public double side2;
        public double Area { get; }
        public double Perimeter { get; }
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
            Area = AreaCalculator();
            Perimeter = PerimeterCalculator();
        }

        public double AreaCalculator()
        {
            return side1 * side2;
        }

        public double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
            Console.Write("S = ");
            Console.WriteLine(rectangle.Area);
            Console.Write("P = ");
            Console.WriteLine(rectangle.Perimeter);
            Console.ReadKey();
        }
    }
}