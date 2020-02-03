using System;

namespace Exercise7
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int x, y, z, sum;

            Console.Write("Enter an integer: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a second integer: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a third integer: ");
            z = Convert.ToInt32(Console.ReadLine());

            sum = AddThreeIntegers(x, y, z);
            Console.WriteLine("The sum of the three integers is " + sum);
            Console.WriteLine();

            Console.Write("Enter an integer: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a second integer: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a third integer: ");
            z = Convert.ToInt32(Console.ReadLine());

            AddThreeIntegers(x, y, z, ref sum);
            Console.WriteLine("The sum of the three integers is " + sum);

            Console.ReadKey();
        }

        private static int AddThreeIntegers(int x, int y, int z)
        {
            return x + y + z;
        }

        private static void AddThreeIntegers(int x, int y, int z, ref int sum)
        {
            sum = x + y + z;
        }
    }
}
