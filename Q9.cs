using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2DotNetNirmala
{
    public class Property
    {
        // Auto-Implemented Property
        public string Name { get; set; }

        // Read-Only Property
        public int Age { get; private set; }

        // Write-Only Property
        private string _password;
        public string Password
        {
            set
            {
                // Here you might include logic for password validation
                _password = value;
            }
        }

        // Computed Property
        public string Greeting => $"Hello, my name is {Name}.";

        // Property with Backing Field
        private string _address;
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        // Constructor to initialize the read-only property
        public Property(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    class Properties
    {
        /*static void Main(string[] args)
        {
            // Create a new Person object
            Property person = new Property("Nirmala", 22);

            // Use auto-implemented property
            Console.WriteLine($"Name: {person.Name}");

            // Use read-only property
            Console.WriteLine($"Age: {person.Age}");

            // Set the write-only property
            person.Password = "SecurePassword123";

            // Use computed property
            Console.WriteLine(person.Greeting);

            // Use property with backing field
            person.Address = "Kawasoti";
            Console.WriteLine($"Address: {person.Address}");

            // Output
            Console.ReadLine();
        }*/
    }
}
