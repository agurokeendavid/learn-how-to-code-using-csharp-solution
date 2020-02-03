using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturningPassingDataLecture3
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;

            result = NumbersAdded(10, 5);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        static int NumbersAdded(int x, int y)
        {
            int z = x + y;
            return z;
        }
    }
}
