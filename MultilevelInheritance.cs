using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignment
{
    class Person7
    {
        public string Name;
        public int Id;
        public void Display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Id: " + Id);
        }
    }
    class Teacher : Person7
    {
        public int Age;
        public void Display1()
        {
            Console.WriteLine("Age: " + Age);

        }
    }
    class Principle : Teacher
    {
        public String Address;
        public int Experience;
        public void Show()
        {
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Experience: " + Experience);
        }
    }
    internal class MultilevelInheritance
    {
        static void Main()
        {
            Principle principle = new Principle();
            principle.Name = "Akshay";
            principle.Id = 10;
            principle.Age = 55;
            principle.Address = "Pune";
            principle.Experience = 25;
            principle.Display();
            principle.Display1();
            principle.Show();

        }
    }
}
