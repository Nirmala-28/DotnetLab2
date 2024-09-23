using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace lab2DotNetNirmala
{
    // Class with different types of constructors
    public class Man
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Static Constructor
        static Man()
        {
        
        }


        // Default Constructor
        public Man()
        {
            Name = "Unknown";
            Age = 0;
            
        }

        // Parameterized Constructor
        public Man(string name, int age)
        {
            Name = name;
            Age = age;
            
        }

        // Copy Constructor
        public Man(Man other)
        {
            Name = other.Name;
            Age = other.Age;
          
        }


        // Method to display person details
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    class Constructor
    {
       /* static void Main(string[] args)
        {
            // Create object using the default constructor
         Console.WriteLine("Default Constructor");
           Man person = new Man();
            person.DisplayInfo(); // Output: Name: Unknown, Age: 0
            Console.WriteLine();

            //static
            Console.WriteLine("Static Constructor");
            Console.WriteLine();

          // Create object using the parameterized constructor
          Console.WriteLine("Parameterized Constructor");
            Man person1 = new Man("Nirmala", 22);
            person2.DisplayInfo(); // Output: Name: Alice, Age: 30
            Console.WriteLine() ;

            // Create object using the copy constructor
            Console.WriteLine("Copy Constructor");
            Man person2 = new Man(person1);
            person3.DisplayInfo(); // Output: Name: Alice, Age: 30
            Console.WriteLine();

            // Output
            Console.ReadLine();
        }*/
    }
}
