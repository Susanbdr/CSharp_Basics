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

        public static int ReturnMaxOfTwoNumbers(int input1, int input2)
        {
            
            return input1 > input2 ? input1 : input2;
        }
    }
}
