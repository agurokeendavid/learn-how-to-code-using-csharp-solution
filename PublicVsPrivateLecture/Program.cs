using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicVsPrivateLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car();
            car1.SetColor("red");
            car1.SetBrand("Toyota");

            var car2 = new Car("green", "Honda");

            car1.Accelerate(20);
            car2.Accelerate(20);
            car2.Decelerate(10);

            car1.DisplaySpeed();
            car2.DisplaySpeed();

            Console.ReadKey();

        }
    }
}
