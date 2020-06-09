using System;
using System.Buffers;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Threading.Channels;

namespace CSharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter few numbers separated by a hyphen. E.g. \"5-6-7-8-9\"");
            var numbers = Console.ReadLine()?.Split('-');
            var list = new List<int>();

            if (numbers != null)
                foreach (var number in numbers)
                    list.Add(Convert.ToInt32(number));

            var result = WorkingWithTextSolutions.CheckIfListIsConsecutive(list);
            Console.WriteLine(result);
        }
    }
}
