using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingAndErrorHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] sales = new double[4];
            double totalSales = 0;
            double totalExpenses;
            double profit;
            double averageProfitPerDistrict;

            // input sales from each of the four districts
            for (int i = 0; i <= 3; i++)
            {
                Console.Write($"Enter sales from district {i + 1}: ");
                sales[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine();

            Console.Write($"Enter total expenses: ");
            totalExpenses = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            // calculate total sales
            for (int i = 0; i <= 3; i++)
            {
                totalSales += sales[i];
            }
            // calculate profit
            profit = totalSales - totalExpenses;

            // calculate average profit per district
            averageProfitPerDistrict = profit / 4;

            Console.WriteLine($"Average profit per district was ${averageProfitPerDistrict.ToString("F")}");
            Console.ReadKey();
        }
    }
}
