using System;
using System.Globalization;

namespace TeachMeSkills.DotNet._Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number between 0 and 100: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (14>=n && n>= 0)
                {
                    Console.WriteLine("The number you specified fell into the intermediate[0 - 14]");
                }
            else if (35 >= n && n >= 15)
            {
                Console.WriteLine("The number you specified fell into the intermediate[15 - 35]");
            }
            else if (50 >= n && n >= 36)
            {
                Console.WriteLine("The number you specified fell into the intermediate[36 - 50]");
            }
            else if (100 >= n && n >= 51)
            {
                Console.WriteLine("The number you specified fell into the intermediate[50 - 100]");
            }
            else if ( n >= 100)
            {
                    Console.WriteLine("Your number is not in the range from 0 to 100");
            }
            else if (0 >= n)
            {
                Console.WriteLine("Your number is not in the range from 0 to 100");
            }
            Console.ReadKey();
        }
    }
}



