using System;

namespace IntroToOOPLecture3
{
    internal class Car
    {
        public string color;
        public string brand;
        public int currentSpeed;

        public void Accelerate(int speedIncrease)
        {
            currentSpeed += speedIncrease;
        }

        public void Decelerate(int speedDecrease)
        {
            currentSpeed -= speedDecrease;
        }

        public void DisplaySpeed()
        {
            Console.WriteLine($"The {color} {brand} is travelling at {currentSpeed} km/h");
        }
    }
}
