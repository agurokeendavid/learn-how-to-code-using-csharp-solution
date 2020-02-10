using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Novel novel1;
            Movie movie1;
            Song song1;

            string name;
            string writer;

            Console.Write("Enter name of novel: ");
            name = Console.ReadLine();
            Console.Write("Enter name of author: ");
            writer = Console.ReadLine();
            novel1 = new Novel(name, writer);
            Console.WriteLine();

            Console.Write("Enter name of movie: ");
            name = Console.ReadLine();
            Console.Write("Enter name of screenwriter: ");
            writer = Console.ReadLine();
            movie1 = new Movie(name, writer);
            Console.WriteLine();

            Console.Write("Enter name of song: ");
            name = Console.ReadLine();
            Console.Write("Enter name of songwriter: ");
            writer = Console.ReadLine();
            song1 = new Song(name, writer);
            Console.WriteLine();

            Console.WriteLine("****************************************");
            Console.WriteLine("LIST OF CREATIVE WORKS");
            Console.WriteLine();

            PrintWriter(novel1);
            PrintWriter(movie1);
            PrintWriter(song1);

            Console.ReadKey();
        }

        static void PrintWriter(IWritable creativeWork)
        {
            Console.WriteLine($"Name of work: {creativeWork.GetNameOfWork()}");
            Console.WriteLine($"Written by: {creativeWork.GetWriter()}");
            Console.WriteLine();
        }
    }
}
