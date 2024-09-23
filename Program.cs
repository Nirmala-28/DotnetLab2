using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2DotNetNirmala
{
       
        public class Employee
        {
            
            public string Name { get; set; }
            public string Email { get; set; }
            public decimal Salary { get; set; }

          
            public Employee(string name, string email, decimal salary)
            {
                Name = name;
                Email = email;
                Salary = salary;
            }

            
            public void DisplayEmployeeInfo()
            {
                Console.WriteLine("Employee Information:");
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Email: {Email}");
                Console.WriteLine($"Salary: {Salary}");
            }
        }

        class Program
        {
           /* static void Main(string[] args)
            {
                
                Employee emp = new Employee("Nirmala Chapagain", "nirmalachapagain@gmail.com", 75000);

                
                emp.DisplayEmployeeInfo();
            }*/
        }
    }
