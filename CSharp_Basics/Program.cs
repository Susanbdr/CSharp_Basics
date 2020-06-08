using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;

namespace CSharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name:");
            var name = Console.ReadLine();
            Console.WriteLine(ArraysAndListsSolutions.ReverseNameUsingArray(name));
            
        }
    }
}
