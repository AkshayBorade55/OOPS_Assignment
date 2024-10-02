using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignment
{
    class Vechical  //base class
    { 
     public string Brand { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{Brand} is Driving");
        }
    }
    class car : Vechical
    { 
     public int NumberofDoors { get; set; }
        public void ShowCarInfo()
        { 
         Console.WriteLine($"{ Brand} car has { NumberofDoors}"); 
            
        }
    }

    class SingleInheritance
    {
        static void Main()
        {
            car mycar = new car();
            mycar.Brand = "Hyundai";
            mycar.NumberofDoors = 4;
            mycar.ShowCarInfo();
        
        }

    }

}
