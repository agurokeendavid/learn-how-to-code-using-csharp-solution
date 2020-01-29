using System;

namespace IterationStatementsLecture
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
             while (expression)
             {
                // do this
             }
             */

            int i = 1;
            while (i <= 3)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.ReadKey();
        }
    }
}
