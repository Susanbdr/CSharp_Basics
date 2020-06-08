using System;

namespace CSharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 1st number:");
            
            var input1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2nd number:");

            var input2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(ConditionalsSolution.ReturnMaxOfTwoNumbers(input1, input2));
        }
    }
}
