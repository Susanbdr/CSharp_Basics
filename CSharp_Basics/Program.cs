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
            Console.WriteLine("Enter few numbers separated by a hyphen");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
                return;

            var list = new List<int>();

            foreach(var number in input.Split('-'))
                list.Add(Convert.ToInt32(number));

            var result = WorkingWithTextSolutions.CheckDuplicateIfAny(list);
            Console.WriteLine(result);
        }
    }
}
