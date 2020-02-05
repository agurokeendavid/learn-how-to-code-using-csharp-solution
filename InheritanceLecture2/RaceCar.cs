﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLecture2
{
    class RaceCar : Car
    {
        private readonly int numNitros;

        public RaceCar(int numNitros) : base()
        {
            this.numNitros = numNitros;
        }

        public RaceCar(string color, string brand, int numNitros) : base(color, brand)
        {
            this.numNitros = numNitros;
        }
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
