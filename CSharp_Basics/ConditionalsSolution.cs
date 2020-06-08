using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Basics
{
    public class ConditionalsSolution
    {
        public static void ValidateNumbersBetween1To10(string input)
        {
            var number = Convert.ToInt32(input);

            if(number <= 0 || number > 10)
                Console.WriteLine("Invalid");
            else
                Console.WriteLine("Valid");
        }
    }
}
