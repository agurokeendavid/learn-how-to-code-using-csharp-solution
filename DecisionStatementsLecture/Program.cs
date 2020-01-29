using System;
namespace DecisionStatementsLecture
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
             if (expression)
                // do this
             */

            int age = 16;

            if (age >= 18) // if one statement curly braces is not required.
                Console.WriteLine("You are old enough to vote!");

            Console.WriteLine("Have a nice day!");
            Console.ReadKey();
        }
    }
}
