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

        public static string CheckTheTimeIsValid(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
                return string.Empty;
            }
            
            var component = input.Split(':');

            if(component.Length !=  2)
            {
                Console.WriteLine("Invalid Time");
                return string.Empty;
            }

            try
            {
                var hour = Convert.ToInt32(component[0]);
                var minute = Convert.ToInt32(component[1]);

                if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                    Console.WriteLine("Ok");
                else
                    Console.WriteLine("Invalid Time");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Time");
            }

            return "";
        }

        public static string ConvertToPascalCase(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return "";
            
            var sentence = input.Split(' ');
            var pascalCase = "";

            foreach (var word in sentence)
                pascalCase += char.ToUpper(word[0]) + word.ToLower().Substring(1);

            return pascalCase;
        }


    }
}