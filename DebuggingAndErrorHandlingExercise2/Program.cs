using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingAndErrorHandlingExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte selection;
            bool wasError;

            do
            {
                wasError = false;
                Console.WriteLine("Please make a selection to learn more information");
                Console.WriteLine("1 - Tyrannosaurus rex");
                Console.WriteLine("2 - Stegosaurus");
                Console.WriteLine("3 - Velociraptor");
                try
                {
                    selection = Convert.ToByte(Console.ReadLine());
                    Console.WriteLine();

                    switch (selection)
                    {
                        case 1:
                            DisplayTyranosaurusRexInfo();
                            break;
                        case 2:
                            DisplayStegosaurusInfo();
                            break;
                        case 3:
                            DisplayVelociraptorInfo();
                            break;;
                        default:
                                throw new Exception($"{selection} is not one of the choices.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine();
                    Console.WriteLine(ex.Message);
                    Console.WriteLine();
                    wasError = true;
                }
            } while (wasError);

            Console.ReadKey();
        }

        private static void DisplayVelociraptorInfo()
        {
            Console.WriteLine("Velociraptor, meaning is a tyrant lizard, from the Ancient Greek veloci, and raptor.");
        }

        private static void DisplayStegosaurusInfo()
        {
            Console.WriteLine("Stegosaurs, meaning is a tyrant lizard, from the Ancient Greek stego, and sauros.");
        }

        static void DisplayTyranosaurusRexInfo()
        {
            Console.WriteLine("Tyrannosaurus, meaning is a tyrant lizard, from the Ancient Greek tyrannos, and sauros.");
        }
    }
}
