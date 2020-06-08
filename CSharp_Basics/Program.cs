using System;
using System.Collections.Generic;

namespace CSharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number or \"ok\" to exit");
            var list = new List<int>();

            for (int i = 0; i <= 20; i++)
            {
                var input = Console.ReadLine();
                if (input == "ok")
                {
                    Console.WriteLine(LoopsSolutions.CalculateSumOfEnteredNumbers(list));
                    break;
                }

                list.Add(Convert.ToInt32(input));
            }
        }
    }
}
