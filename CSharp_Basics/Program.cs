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
            Console.WriteLine("Enter a time value in the 24-hour time format (e.g. 19:00). ");
            var input = Console.ReadLine();

            var result = WorkingWithTextSolutions.CheckTheTimeIsValid(input);
            Console.WriteLine(result);


        }
    }
}
