using System;
namespace lab2DotNetNirmala
{
    // This is the first part of the partial class
    public partial class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void DisplayFullName()
        {
            Console.WriteLine($"Full Name: {FirstName} {LastName}");
        }
    }
}
