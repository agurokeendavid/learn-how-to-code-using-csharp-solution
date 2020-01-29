using System;

namespace DecisionStatementsLecture2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int age = 20;

            int x = 10;

            if (age >= 18)
            {
                x = 5;
                Console.WriteLine("You are old enough to vote!");
                Console.WriteLine("Congratulations");
            }
            // the value of x is 5 because if statement is true.
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
