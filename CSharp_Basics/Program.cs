using System;

namespace CSharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Height:");
            
            var height = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Width:");

            var width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(ConditionalsSolution.LandScapeOrPortrait(height, width));
        }
    }
}
