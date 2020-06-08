using System;
using System.Collections.Generic;

namespace CSharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to find out the factorial of the number");
            var fact = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(LoopsSolutions.FactorialUsingRecursion(fact));

        }
    }
}
