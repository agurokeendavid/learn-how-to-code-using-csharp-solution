using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string yourName = Console.ReadLine(); // declare "yourName" string variable that holds input value.
            Console.Write("Enter your age: ");
            int yourAge = Convert.ToInt32(Console.ReadLine()); // declare "yourAge" int variable that holds input value.

            Console.WriteLine("Your name is {0} and you are {1} years old", yourName, yourAge);
            Console.WriteLine();
            Console.Write("Enter your friend's name: ");
            string friendsName = Console.ReadLine(); // declare "friendsName" string variable that holds input value.
            Console.Write("Enter your frien's age: ");
            int friendsAge = Convert.ToInt32(Console.ReadLine()); // declare "friendsAge" int variable that holds input value.
            Console.WriteLine("Your friend's name is {0} and they are {1} years old.", friendsName, friendsAge);

            Console.WriteLine();
            Console.WriteLine($"There are {yourAge + friendsAge} years between the two of you");
            Console.ReadKey();
        }
    }
}
