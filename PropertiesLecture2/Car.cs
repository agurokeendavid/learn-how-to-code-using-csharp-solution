using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesLecture2
{
    class Car
    {
        private string _color;
        private string _brand;

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public string Brand
        {
            get { return _brand; }
            set
            {
                if (isBrandValid(value))
                    _brand = value;
                else
                    Console.WriteLine("Invalid Brand");
            }
        }

        private bool isBrandValid(string brand)
        {
            var brandNames = new List<string> { "Toyota", "Honda", "Ford" };
            if (brandNames.Contains(brand))
                return true;
            else
                return false;
        }
    }
}
