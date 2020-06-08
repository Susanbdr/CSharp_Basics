﻿using System;
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

        public static int FactorialUsingIteration(int fact)
        {
            var result = 1;

            for (int i = fact; i > 1; i--)
                result *= i;

            return result;
        }

        public static int FactorialUsingRecursion(int fact)
        {
            if (fact == 0)
                return 1;

            return fact * FactorialUsingRecursion(fact - 1);
        }
    }
}
