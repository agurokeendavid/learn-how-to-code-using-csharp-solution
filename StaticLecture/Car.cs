using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticLecture
{
    class Car
    {
        private string color;
        private string brand;
        private int currentSpeed;
        private static int numCarObjects = 0;

        public Car()
        {
            currentSpeed = 0;
            numCarObjects--;
        }

        public Car(string color, string brand)
        {
            this.color = color;
            this.brand = brand;
            currentSpeed = 0;
            numCarObjects++;
        }

        public static int GetNumCarObjects()
        {
            return numCarObjects;
        }

        public string GetColor()
        {
            return color;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

        public string GetBrand()
        {
            return brand;
        }

        public void SetBrand(string brand)
        {
            if (IsBrandValid(brand))
                this.brand = brand;
            else
                Console.WriteLine("Invalid brand");
        }

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

        private bool IsBrandValid(string brand)
        {
            var brandNames = new List<string> { "Toyota", "Honda", "Ford" };
            if (brandNames.Contains(brand))
                return true;
            else
                return false;
        }
    }
}
