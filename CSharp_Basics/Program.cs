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
            Console.WriteLine("Enter a name");
            var exist = true;
            var names = new List<string>();
            while (exist)
            {
                var name = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(name))
                {
                    names.Add(name);
                    Console.WriteLine("Enter a different name");
                }
                else
                    exist = false;
            }


            var result = ArraysAndListsSolutions.DisplayFacebookPostInformation(names);

            Console.WriteLine(result);
        }
    }
}
