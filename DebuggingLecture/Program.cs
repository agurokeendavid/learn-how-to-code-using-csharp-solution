using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInteger = 5;
            
            var car1 = new Car("red", "Toyota");

            myInteger = 7;

            car1.Accelerate(20);
            car1.Decelerate(10);

            Console.WriteLine(myInteger);

            car1.Accelerate(20);
            car1.Decelerate(10);

            if (myInteger > 5)
                Console.WriteLine(myInteger);

            Console.ReadKey();
        }
    }
}
