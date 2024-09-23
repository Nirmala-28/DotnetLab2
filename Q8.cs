using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2DotNetNirmala
{
    // Define a class with binary operator overloads
    public class Number
    {
        public int Value { get; set; }

        // Constructor
        public Number(int value)
        {
            Value = value;
        }

        // Overload binary + operator
        public static Number operator +(Number a, Number b)
        {
            return new Number(a.Value + b.Value);
        }

        // Overload binary - operator
        public static Number operator -(Number a, Number b)
        {
            return new Number(a.Value - b.Value);
        }

        // Method to display the value
        public void Display()
        {
            Console.WriteLine(Value);
        }
    }

    class Binary
    {
        /*static void Main(string[] args)
        {
            Number a = new Number(10);
            Number b = new Number(5);

            // Display original values
            Console.Write("Original  value a: ");
            a.Display(); // Output: 10

            Console.Write("Original  value b: ");
            b.Display(); // Output: 5

            // Apply binary + operator
            Number resultAdd = a + b;
            Console.Write("After binary + operator (a + b): ");
            resultAdd.Display(); // Output: 15

            // Apply binary - operator
            Number resultSubtract = a - b;
            Console.Write("After binary - operator (a - b): ");
            resultSubtract.Display(); // Output: 5

            // Output
            Console.ReadLine();
        }*/
    }
}