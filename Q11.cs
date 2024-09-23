using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2DotNetNirmala
{
    // Generic class
    public class Container<T>
    {
        private T _data;

        // Method to set the value
        public void SetValue(T value)
        {
            _data = value;
        }

        // Method to get the value
        public T GetValue()
        {
            return _data;
        }
    }

    // Class with a generic method
    public class Utilities
    {
        // Generic method to display the type and value of the data
        public void DisplayInfo<T>(T data)
        {
            Console.WriteLine($"Type: {typeof(T)}, Value: {data}");
        }
    }

    class Q11
    {
        static void Main(string[] args)
        {
            // Create a Container for an integer
            Container<int> intContainer = new Container<int>();
            intContainer.SetValue(123);
            Console.WriteLine("Integer Container Value: " + intContainer.GetValue());

            // Create a Container for a string
            Container<string> stringContainer = new Container<string>();
            stringContainer.SetValue("Hello, Nirmala!");
            Console.WriteLine("String Container Value: " + stringContainer.GetValue());

            // Use the generic method from Utilities
            Utilities utilities = new Utilities();
            utilities.DisplayInfo(456); // Display an integer
            utilities.DisplayInfo("Generic Method Test"); // Display a string

            // Output
            Console.ReadLine();
        }
    }
}
