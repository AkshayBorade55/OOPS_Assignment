using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignment
{
    class ShapeNew
    {
        public string? ColorName { get; set; }
        public void DisplayDetails()
        {
            Console.WriteLine("Color of the Shape:" + ColorName);
        }

    }
    class Circle1 : ShapeNew
    {
        public string ColorName1;
        public void CircleColor()
        {
            Console.WriteLine("Color of Circle: " + ColorName1);
        }
    }
    class Rectangle1 : ShapeNew
    {
        public string ColorName2;
        public void RectColor()
        {
            Console.WriteLine("Color Of Rectangle: " + ColorName2);
        }
    }


    class HierarchicalInheretance
    {
        static void Main()
        {
            Circle1 circle1 = new Circle1();
            circle1.ColorName1 = "Red";
            circle1.DisplayDetails();
            circle1.CircleColor();

            Rectangle1 rectangle1 = new Rectangle1();
            rectangle1.ColorName2 = "Yellow";
            circle1.DisplayDetails();
            rectangle1.RectColor();
            
        }
    }
}
