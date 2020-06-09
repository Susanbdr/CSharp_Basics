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
            Console.WriteLine("Enter a few words separated by a space. ");
            var input = Console.ReadLine();

            var result = WorkingWithTextSolutions.ConvertToPascalCase(input);
            Console.WriteLine(result);


        }
    }
}
