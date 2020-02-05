using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Car.GetNumCarObjects());

            var car1 = new Car("red", "Toyota");
            Console.WriteLine(Car.GetNumCarObjects());

            var car2 = new Car("green", "honda");
            Console.WriteLine(Car.GetNumCarObjects());

            var car3 = new Car();
            Console.WriteLine(Car.GetNumCarObjects());

            Console.ReadKey();
        }
    }
}
