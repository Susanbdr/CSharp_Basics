using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

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
    }
}
