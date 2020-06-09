using System;
using System.Buffers;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading.Channels;

namespace CSharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an English word. ");
            var input = Console.ReadLine();

            var result = WorkingWithTextSolutions.CountTheNumberOfVowels(input);
            Console.WriteLine(result);


        }
    }
}
