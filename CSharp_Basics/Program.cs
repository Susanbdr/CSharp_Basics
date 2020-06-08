using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace CSharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a series of numbers separated by comma. For e.g. 5,3,8,1,4");
            var input = Console.ReadLine()?.Split(',');
            var list = new List<int>();
            if (input != null)
                foreach (var num in input)
                    list.Add(Convert.ToInt32(num));

            Console.WriteLine(LoopsSolutions.ReturnMaximumNumberFromTheList(list));


        }
    }
}
