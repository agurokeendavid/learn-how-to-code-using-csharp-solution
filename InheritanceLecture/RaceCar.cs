using System;

namespace InheritanceLecture
{
    internal class RaceCar : Car
    {
        private readonly int numNitros;


        public void UseNitro()
        {
            if (numNitros > 0)
            {
                Accelerate(20);
            }
            else
            {
                Console.WriteLine("Out of nitro!");
            }
        }
    }
}
