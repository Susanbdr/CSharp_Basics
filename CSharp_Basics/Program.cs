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
            var list = new List<int>();
            
            for (var i = 1; i <= 5; i++)
            {
                Console.Write("Enter 5 numbers:");
                var input = Convert.ToInt32(Console.ReadLine());
                if (list.Contains(input))
                {
                    Console.WriteLine("Duplicate number: Re-try");
                    list.Clear();
                    i = 0;
                }
                else
                    list.Add(input);
            }

            ArraysAndListsSolutions.SortListOfNumbers(list);
        }
    }
}
