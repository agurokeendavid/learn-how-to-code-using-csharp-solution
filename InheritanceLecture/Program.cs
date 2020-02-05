using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            var myRaceCar = new RaceCar();

            myRaceCar.UseNitro();
            myRaceCar.Decelerate(5);

            var myPickupTruck = new PickupTruck();
            myPickupTruck.Accelerate(10);
            myPickupTruck.bedLength = 100;
            
            Console.ReadKey();
        }
    }
}
