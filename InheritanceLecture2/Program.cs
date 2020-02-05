using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLecture2
{
    class Program
    {
        static void Main(string[] args)
        {
            var myRaceCar = new RaceCar(5);
            var myRaceCar2 = new RaceCar("red", "Toyota", 5);



            Console.ReadKey();
        }
    }
}
