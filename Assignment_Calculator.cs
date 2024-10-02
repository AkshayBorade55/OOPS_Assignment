using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignment
{
    class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public double Substraction(double x, double y)
        {
            return x - y;
        }
        public double Multiplication(double x, double y)
        {
            return x * y;
        }
        public double Divide(double x, double y)
        {
            return x / y;
        }

    }

    internal class Assignment_Calculator
    {
        static void Main()
        {
            Calculator calculator = new Calculator();
            int sum = calculator.Add(10, 15);
            double substraction = calculator.Substraction(20.15, 11);
            double multiplication = calculator.Multiplication(18.5, 20.5);
            double divide = calculator.Divide(40, 10);
            Console.WriteLine("Sum Of Intergers: " + sum);
            Console.WriteLine("Substraction : " + substraction);
            Console.WriteLine("Multiplication: " + multiplication);
            Console.WriteLine("Divide: " + divide);

        }



    }
}
