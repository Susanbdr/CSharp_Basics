using System;
using System.Collections.Generic;
using CSharp_Basics.CustomExceptions;

namespace CSharp_Basics
{
    public class WorkingWithTextSolutions
    {
        public static string CheckIfListIsConsecutive(List<int> list)
        {
            if(list == null || list.Count == 0)
                throw new CustomerException("Collection is empty");

            list.Sort();

            for (int i = 1; i < list.Count; i++)
                if(list[i] != list[i - 1] + 1)
                    return "Not Consecutive";

            return "Consecutive";
        }
    }
}