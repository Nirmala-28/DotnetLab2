using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2DotNetNirmala
{

    class Member
    {
        private int id;
        private string name;

        public Member(int i, string n)
        {
            id = i;
            name = n;
        }
        public void PrintDetails()
        {
            Console.WriteLine("ID: {0} \nName : {1}", id, name);
        }
    }
    //single level
    class Teacher : Member
    {
        private string panno;
        public Teacher(int i, string n, string pan) : base(i, n)
        {
            panno = pan;
        }
        public void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine("Pan No: {0}", panno);
           
        }
    }
    //multilevel
    class BCATeacher : Teacher
    {
        private bool isTechnical;
        public BCATeacher(int i, string n, string pan, bool it) : base(i, n, pan)
        {
            isTechnical = it;
        }
        public void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine("Is Technical: {0}", isTechnical);
        }
    }
    //hierarchical
    class Student : Member
    {
        private string rollno;
        public Student(int i, string n, string roll) : base(i, n)
        {
            rollno = roll;
        }
        public void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine("Roll No: {0}", rollno);
        }
    }
    internal class InheritDemo
    {
        /* static void Main(string[] args)
          {
            Console.WriteLine("Single level inheritance");
            Teacher t = new Teacher(120, "Nirmala", "2154545");
              t.PrintDetails();
            Console.WriteLine();

            Console.WriteLine("Hierarchical inheritance");
              Student s = new Student(121, "Yashoda", "646454");
              s.PrintDetails();
            Console.WriteLine();


            Console.WriteLine("Multilevel inheritance");
              BCATeacher bt = new BCATeacher(122, "Kalyan", "646454",false);
              bt.PrintDetails();
            Console.WriteLine();

              Console.ReadKey();
          }*/
    }
}