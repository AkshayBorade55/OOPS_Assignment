using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignment
{
    class PersonNew
    {
        public string Name { get; set; }
        public int RollNo { get; set; }
        public void DisplayNew()
        {
            Console.WriteLine("NAME: " + Name);
            Console.WriteLine("Roll No: " + RollNo);

        }
    }
    class StudentNew : PersonNew
    {
        public string Email { get; set; }
        public void Display1()
        {
            Console.WriteLine("Email Id: " + Email);
        }
    }
    class SingleInheretanceAssignment
    {
        static void Main()
        {
            StudentNew std = new StudentNew();
            std.Name = "Akshay";
            std.RollNo = 55;
            std.Email = "akshay55@gmail.com";
            std.DisplayNew();
            std.Display1();

        }
    }
}
