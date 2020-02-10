﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsLecture2
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack(10);
            string myString;
            int myInteger;

            stack.Push("hello");
            stack.Push("world");

            myString = (string) stack.Pop();
            myInteger = (int) stack.Pop(); // does not create a compiler error, but will be a runtime error that will crash program

            // allowed to mix data types in a single instance, which makes it difficult to work with, without producing runtime errors.
            stack.Push("hello");
            stack.Push(4);
            stack.Push(2.34);

            Console.ReadKey();
        }
    }
}
