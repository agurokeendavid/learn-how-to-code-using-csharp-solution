using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesLecture
{
    class MyClass
    {
        //private int _myInteger;

        //public int MyInteger
        //{
        //    get { return _myInteger; }
        //    set { _myInteger = value; }
        //}

        public int MyInteger { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var myObject = new MyClass();
            myObject.MyInteger = 5; // calls set accessor
            Console.WriteLine(myObject.MyInteger); // calls get accessor
            Console.ReadKey();
        }
    }
}
