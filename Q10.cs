using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2DotNetNirmala
{
    // Base class Shape
    public class Shape
    {
        // Properties
        public double Length { get; set; }
        public double Breadth { get; set; }

        // Default Constructor
        public Shape()
        {
            Length = 0;
            Breadth = 0;
        }

        // Parameterized Constructor
        public Shape(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }
    }

    // Derived class Rectangle
    public class Rectangle : Shape
    {
        // Constructor to initialize the base class properties
        public Rectangle(double length, double breadth) : base(length, breadth)
        {
        }

        // Method to calculate the area of the rectangle
        public double CalculateArea()
        {
            return Length * Breadth;
        }
    }

    class Parameterized
    {
       /* static void Main(string[] args)
        {
            // Create a Rectangle object using the parameterized constructor
            Rectangle rectangle = new Rectangle(5.0, 3.0);

            // Calculate and display the area of the rectangle
            double area = rectangle.CalculateArea();
            Console.WriteLine($"Length: {rectangle.Length}");
            Console.WriteLine($"Breadth: {rectangle.Breadth}");
            Console.WriteLine($"Area of Rectangle: {area}");

            // Output
            Console.ReadLine();
        }*/
    }
}