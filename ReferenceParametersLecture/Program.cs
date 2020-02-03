using System;

namespace ReferenceParametersLecture
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // ref keyword - used to store the reference value of variable that has been initialized inside the method that is being called.
            // out keyword - used to store the reference value of variable even though it has not been initialized inside the method that is being called.
            int x = 5;

            ChangeNumber(out x);

            Console.WriteLine(x);
            Console.ReadKey();
        }

        private static void ChangeNumber(out int y)
        {
            y = 0;
        }
    }
}
