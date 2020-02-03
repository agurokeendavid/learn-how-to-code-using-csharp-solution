using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationLecture3
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString;

            myString = "abc";
            Console.WriteLine(myString.Length);

            myString = "I'm Learning C#";
            Console.WriteLine(myString.ToLower());
            Console.WriteLine(myString.ToUpper());

            myString = "This is fun!";
            Console.WriteLine(myString.Contains("fun")); // outputs "True"
            Console.WriteLine(myString.Contains("boring")); // outputs "False"

            Console.WriteLine(myString.IndexOf('i')); // outputs "2"
            Console.WriteLine(myString.IndexOf('j')); // outputs "-1"

            Console.WriteLine(myString.Substring(5)); // outputst "is fun!"
            Console.WriteLine(myString.Substring(5, 2)); // outputs "is"

            Console.WriteLine(myString.Remove(5)); // outputs "is fun!"
            Console.WriteLine(myString.Remove(5, 2)); // outputs "This fun!"

            Console.WriteLine(myString.Replace("fun", "awesome")); //outputs "This is awesome!"

            int myInt = 5;
            double myDouble = 5.4475453;
            bool myBool = false;

            myString = myInt.ToString();
            myString = myDouble.ToString("F"); // "5.45" will be stored in myString "F" means round the value into two decimal places.
            myString = myBool.ToString();

            Console.ReadKey();
        }
    }
}
