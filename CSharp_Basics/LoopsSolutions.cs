using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Xsl;

namespace CSharp_Basics
{
    public class LoopsSolutions
    {
        public static int NumbersDivisibleBy3()
        {
            var count = 0;

            for (int i = 1; i <= 100; i++)
                if (i % 3 == 0)
                    count++;
            
            return count;
        }

        public static int CalculateSumOfEnteredNumbers(List<int> list)
        {
            var sum = 0;
            foreach (var num in list)
                sum += num;

            return sum;
        }
    }
}
