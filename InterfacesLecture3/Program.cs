using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesLecture3
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void PrintObject(IDisplay displayObject)
        {
            Console.WriteLine("Here is the object's data:\n");
            Console.WriteLine("###################################################");
            Console.WriteLine("*****************************************************\n");

            displayObject.DisplayInfo(); // compiler error - how to do you call a method when you don't know what object will be passed in?

            Console.WriteLine("\n******************************************************");
            Console.WriteLine("######################################################");
        }
    }
}
