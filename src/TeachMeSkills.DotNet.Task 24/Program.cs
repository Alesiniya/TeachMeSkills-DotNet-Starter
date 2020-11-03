using System;
using System.Linq;
using System.Collections.Generic;

namespace TeachMeSkills.DotNet.Task_24
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            int minValue = numbers.Min();
            Console.WriteLine("Minimum array value");
            Console.WriteLine( minValue);
            int maxValue = numbers.Max();
            Console.WriteLine("Maxmimum array value");
            Console.WriteLine(maxValue);
            int SumValue = numbers.Sum();
            Console.WriteLine("Sum array");
            Console.WriteLine(SumValue);
            int SrValue = (int) numbers.Average();
            Console.WriteLine("Arithmetic mean of an array");
            Console.WriteLine(SrValue);
            for (int i = 0; i <  numbers.Length; i++)
            {
                if ((numbers[i] % 2) == 1)
                {
                    Console.WriteLine("Odd array values");
                    Console.WriteLine(numbers[i]);
                }
            }
            Console.ReadLine();
        }
    }
}