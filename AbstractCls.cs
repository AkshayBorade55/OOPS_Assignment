using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignment
{
    public abstract class Animals
    {
        //abstract method (no implimentation)
        public abstract void MakeSound();

        //non abstract method (that has implimentation)

        public void Eat()
        {
            Console.WriteLine("Animal is Eating");
        
        }
       
    }
    public class Dog : Animals 
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog Braks");
        }
    }
    public class Cat : Animals 
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat Meows");
        }

    }

    internal class AbstractCls
    {
        static void Main()
        {
            //creating objects of derived classes
            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.MakeSound();
            dog.Eat();

            cat.MakeSound();
            cat.Eat();

        }
    }

}
