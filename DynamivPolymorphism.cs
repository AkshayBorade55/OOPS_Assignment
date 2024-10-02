using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignment
{
    public class Animal()
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a Shape: ");
        }

    }
    public class Circle : Animal
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle: ");
        }
    }
    public class Rectangle : Animal 
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle:");
        }
    
    }


    internal class DynamicPolymorphism 
    {
        static void Main()
        {
            Animal shape1 = new Animal();
            shape1.Draw();
            Animal shape2 = new Circle();
            shape2.Draw();
            Animal shape3 = new Rectangle();
            shape3.Draw();
        
        }

    }
}
