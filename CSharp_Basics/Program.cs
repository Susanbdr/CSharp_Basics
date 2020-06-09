using System;

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
