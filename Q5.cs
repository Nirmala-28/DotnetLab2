using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2DotNetNirmala
{ // Base class
    public class Animals
    {
        // Virtual method
        public virtual void Sound()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }

    // Derived class
    public class horse : Animals
    {
        // Override the virtual method
        public override void Sound()
        {
            Console.WriteLine("horse neigh.");
        }
    }

    // Another derived class
    public class hen : Animals
    {
        // Override the virtual method
        public override void Sound()
        {
            Console.WriteLine("hen cluck.");
        }
    }

    class pgro
    {
       /* static void Main(string[] args)
        {
            // Create an array of Animal references
            Animals[] animal = new Animals[]
            {
                new horse(),
                new hen(),
                new Animals()
            };

            // Call the Speak method on each animal
            foreach (var animals in animal)
            {
                animals.Sound();
            }

            // Output
            Console.ReadLine();
        }*/
    }
}
