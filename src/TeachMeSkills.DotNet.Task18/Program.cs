using System;

namespace TeachMeSkills.DotNet.Task18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number ");
            double a = Convert.ToDouble(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine("This is a positive number");
            }
            else if (a < 0)
            {
                Console.WriteLine("This is a negative number");
            }
            else if (a == 0)
            {
                Console.WriteLine("You entered zero");
            }
            bool p = true;
            for (int i = 2; i <= a/2; i++)
            {
                if (a % i == 0)
                {
                    p = false;
                    break;
                }
            }
            if (p)
            {
                Console.WriteLine("Prime number");
            }
            else if (!p)
            {
                Console.WriteLine("Number is not prime");
            }
            if (a % 2 == 0)
            {
                Console.WriteLine("Divided by 2");
            }
            if (a % 3 == 0)
            {
                Console.WriteLine("Divided by 3");
            }
            if (a % 6 == 0)
            {
                Console.WriteLine("Divided by 6");
            }
            if (a % 5 == 0)
            {
                Console.WriteLine("Divided by 5");
            }
            if (a % 9 == 0)
            {
                Console.WriteLine("Divided by 9");
            }
            Console.ReadKey();
        }
    }
}
