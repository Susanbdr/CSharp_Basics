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
    }
}
