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

        public static string CheckDuplicateIfAny(List<int> list)
        {

            var list2 = new List<int>();
            foreach (var num in list)
                if (list2.Contains(num))
                    return "Duplicate";
                else
                    list2.Add(num);

            return string.Empty;
        }
    }
}