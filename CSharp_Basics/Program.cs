using System;
using System.Collections.Generic;

namespace CSharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to get. You get 4 tries");

            for (var i = 1; i <= 4; i++)
            {
                var userInput = Convert.ToInt32(Console.ReadLine());
                var result = LoopsSolutions.PickRandomNumber(userInput);

                if (result == "\"You won\"")
                {
                    Console.WriteLine(result);
                    break;
                }

                Console.WriteLine("Try again.");

            }

           
        }
    }
}
