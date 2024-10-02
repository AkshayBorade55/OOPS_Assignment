using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignment
{
    abstract class shape
    {
        public abstract double calculateArea(double x, double y);

        public void display()
        {
            Console.WriteLine("Type of Shape");
        }

    }
    class Reactangle : shape
    {
        public override double calculateArea(double x, double y)
        {
            return x * y;
        }
    }
     class CircleNew : shape
    {
        public override double calculateArea(double r, double pi)
        {
            return  3.14 * r * r;
        }
    }

    internal class AbstractClassAssignment
    {
        static void Main()
        {
            Reactangle obj1 = new Reactangle();
            CircleNew obj2 = new CircleNew();

            double areaRec = obj1.calculateArea(20.1, 12.2);
            Console.WriteLine("area " + areaRec);
            double areaCir = obj2.calculateArea(10.2, 0);
            Console.WriteLine("area" +areaCir);
             


        }

    }
}
