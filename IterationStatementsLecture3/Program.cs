using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationStatementsLecture3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * for (initialize variable; expression; update variable)
             * {
             *      // do this
             * }
             * 
             */

            // continue, break - used for breaking or passing the statement

            for (int i = 1; i <= 3; i++)
            {
                if (i == 2)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
