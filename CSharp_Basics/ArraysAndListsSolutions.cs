using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Channels;

namespace CSharp_Basics
{
    public class ArraysAndListsSolutions
    {
        public static string DisplayFacebookPostInformation(List<string> names)
        {

            if (names.Count == 1)
                return names[0] + " likes your post";

            if (names.Count == 2)
                return names[0] + " and " + names[1] + " like your post";

            if(names.Count > 2)
                return names[0] + ", " + names[1] + $", and {names.Count - 2} others like your post.";

            return string.Empty;
        }

        public static string ReverseNameUsingArray(string name)
        {
            var reversedName = name.ToCharArray();

            for (int i = 0; i < reversedName.Length; i++)
                reversedName[i] = name[name.Length - 1 - i];

            return new string(reversedName);
        }

        public static void SortListOfNumbers(List<int> list)
        {
            if(list == null || list.Count == 0)
                throw new ArgumentNullException(nameof(list),"The list is empty");

            list.Sort();

            foreach(var num in list)
                Console.WriteLine(num);
        }

        public static List<int> DisplayUniqueNumbers()
        {
            var exit = true;
            var list = new List<int>();
            while (exit)
            {
                Console.WriteLine("Enter a number or type \"Quit\" to exit.");
                var input = Console.ReadLine();
                
                if (input == "Quit" || input == "quit")
                {
                    exit = false;
                }
                else
                {
                    var inputToInt = Convert.ToInt32(input);
                    if (!list.Contains(inputToInt))
                        list.Add(inputToInt);
                    else
                        list.Remove(inputToInt);
                }
            }

            return list;
        }

        public static void Display3SmallestNumbers()
        {
            var isValid = true;
            while (isValid)
            {
                Console.WriteLine("Enter a list of comma separated numbers (e.g 5, 1, 9, 2, 10)");
                var input = Console.ReadLine()?.Split(',');
                var list = new List<int>();
                if(input != null && (input.Length <= 0 || input.Length <= 3))
                    Console.WriteLine("Invalid List: Try-again");
                else if (input != null)
                {
                    foreach (var item in input)
                        list.Add(Convert.ToInt32(item));

                    list.Sort();

                    for (int i = 0; i < 3; i++)
                        Console.WriteLine(list[i]);
                    isValid = false;
                }
            }
               

        }
    }
}
