using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationsLecture
{
    class Program
    {
        enum DayOfWeek : byte { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
        static void Main(string[] args)
        {
            DayOfWeek currentDay;

            currentDay = DayOfWeek.Tuesday;
            Console.WriteLine(currentDay); // outputs "Tuesday"

            Console.WriteLine((int)currentDay); // outputs 2
            Console.ReadKey();
        }
    }
}
