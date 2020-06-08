using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;

namespace CSharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = ArraysAndListsSolutions.DisplayUniqueNumbers();

            foreach(var uniqueNum in list)
                Console.WriteLine(uniqueNum);


        }
    }
}
