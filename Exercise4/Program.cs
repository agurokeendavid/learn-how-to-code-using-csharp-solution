using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isValidResponse;

            do
            {
                Console.Write("Do you like pizza? (yes/no): ");
                string response = Console.ReadLine().ToLower();
                switch ( response )
                {
                    case "yes":
                        isValidResponse = true;
                        Console.WriteLine("You like pizza!");
                        break;
                    case "no":
                        isValidResponse = true;
                        Console.WriteLine("You don't like pizza!");
                        break;
                    default:
                        isValidResponse = false;
                        Console.WriteLine("You did not enter a valid response, please try again!");
                        break;
                }
            } while (isValidResponse == false);
            Console.ReadKey();
        }
    }
}
