using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 1;
            int sum;

            sum = x + y;

            double double1 = 5.0 / 2.0;
            double double2 = 5 / 2;

            int remainder;
            remainder = 7 % 3;
            remainder = 6 % 3;

            y = 1;
            x = ++y;

            y = 1;
            x = ++y;

            y = 2;
            x = --y;

            y = 1;
            x = y++;

            y = 2;
            x = y--;

            x += y;
            x = x + y;

            x -= y;
            x = x - y;

            x *= y;
            x = x * y;

            x /= y;
            x = x / y;

            sum = 1 + 2 * 5; // evaluates to 11;

            /*
             * HIGHEST PRECENDENCE
             *  ++, -- (prefix)
             *  *, /, %
             *  +, -
             *  =, +=, -=, *=, /=
             *  ++, -- (postfix)
             *  LOWEST PRECENDENCE
             *  Use parenthesis () to override precendence
             *  */

            sum = (1 + 2) * 5;

            string string1 = "pro";
            string string2 = "gramming";
            Console.WriteLine(string1 + string2); // outputs "programming"

            Console.ReadKey();
        }
    }
}
