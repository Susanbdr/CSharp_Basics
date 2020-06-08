using System;

namespace CSharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number between 1 to 10: ");
            var input = Console.ReadLine();
            ConditionalsSolution.ValidateNumbersBetween1To10(input);
        }
    }
}
