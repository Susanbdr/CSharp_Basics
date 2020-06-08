using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
