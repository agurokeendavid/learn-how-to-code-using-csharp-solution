using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesLecture2
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car();

            car1.Color = "red";
            car1.Brand = "Toyota";

            Console.WriteLine(car1.Color);
            Console.WriteLine(car1.Brand);
        }
    }
}
