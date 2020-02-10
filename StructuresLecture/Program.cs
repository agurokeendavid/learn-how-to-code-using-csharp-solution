using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuresLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            var myVector = new Vector(1, 2, 3);
            Vector myVector2;

            myVector.X = 3;
            myVector.Y = 2;
            myVector.Z = 1;

            myVector.DisplayVector();

            myVector2 = myVector; // makes a copy of each field
            Console.ReadKey();
        }
    }
}
