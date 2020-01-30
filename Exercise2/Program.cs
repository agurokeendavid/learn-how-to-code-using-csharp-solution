using System;

namespace Exercise2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Is guacamole on sale? (yes/no): ");
            string response = Console.ReadLine();
            bool isGuacamoleIsSale;
            if (response == "yes")
            {
                isGuacamoleIsSale = true;
            }
            else
            {
                isGuacamoleIsSale = false;
            }
            Console.Write("How much money is in your pocket? ");
            double money = Convert.ToDouble(Console.ReadLine());
            if ((isGuacamoleIsSale && money >= 10) || money >= 100)
            {
                Console.WriteLine("Let's go shopping!");
            }
            else
            {
                Console.WriteLine("Let's stay home.");
            }
            Console.ReadKey();
        }
    }
}
