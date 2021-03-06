﻿using System;
using System.Collections.Generic;
using System.Text;
using CSharp_Basics.Enum;

namespace CSharp_Basics
{
    public class ConditionalsSolution
    {
        public static void ValidateNumbersBetween1To10(string input)
        {
            var number = Convert.ToInt32(input);

            if(number <= 0 || number > 10)
                Console.WriteLine("Invalid");
            else
                Console.WriteLine("Valid");
        }

        public static int ReturnMaxOfTwoNumbers(int input1, int input2)
        {
            
            return input1 > input2 ? input1 : input2;
        }

        public static string LandScapeOrPortrait(int height, int width)
        {
            return height > width ? ImageMode.LandScape.ToString() : ImageMode.Portrait.ToString();
        }

        public static void SpeedLimit(int speedLimit, int speedOfCar)
        {
            if(speedOfCar <= speedLimit)
                Console.WriteLine("Ok");
            else
            {
                const int aboveSpeedLimit = 5;
                var demeritPoint = (speedOfCar - speedLimit) / aboveSpeedLimit;

                if (demeritPoint < 12)
                    Console.WriteLine(demeritPoint + " demerit points incurred.");
                else
                    Console.WriteLine("License Suspended.");
            }
        }
    }
}
