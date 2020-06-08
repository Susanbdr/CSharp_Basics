using System;

namespace CSharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Speed Limit: ");
            
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter speed of your car: ");

            var speedOfCar = Convert.ToInt32(Console.ReadLine());

            ConditionalsSolution.SpeedLimit(speedLimit, speedOfCar);
        }
    }
}
