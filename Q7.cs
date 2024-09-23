using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2DotNetNirmala
{
    // Define a class with unary operator overloads
    public class MyNumber
    {
        public int Value { get; set; }

        // Constructor
        public MyNumber(int value)
        {
            Value = value;
        }

        // Overload unary + operator
        public static MyNumber operator +(MyNumber num)
        {
            // Unary + does nothing to the value, just returns the same number
            return new MyNumber(+num.Value);
        }

        // Overload unary - operator
        public static MyNumber operator -(MyNumber num)
        {
            // Unary - negates the value
            return new MyNumber(-num.Value);
        }

        // Method to display the value
        public void Display()
        {
            Console.WriteLine(Value);
        }
    }

    class Unary
    {
       /* static void Main(string[] args)
        {
            MyNumber num1 = new MyNumber(10);
            MyNumber num2 = new MyNumber(-5);

            // Display original values
            Console.Write("Original num1: ");
            num1.Display(); // Output: 10

            Console.Write("Original num2: ");
            num2.Display(); // Output: -5

            // Apply unary + operator
            MyNumber result1 = +num1;
            Console.Write("After unary + operator on num1: ");
            result1.Display(); // Output: 10

            // Apply unary - operator
            MyNumber result2 = -num2;
            Console.Write("After unary - operator on num2: ");
            result2.Display(); // Output: 5

            // Output
            Console.ReadLine();
        }*/
    }
}
