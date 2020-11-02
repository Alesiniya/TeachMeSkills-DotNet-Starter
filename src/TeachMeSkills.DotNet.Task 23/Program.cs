using System;

namespace TeachMeSkills.DotNet.Task_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indicate the number of deliveries");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}! = {1}", x, Factorial(x));
            Console.ReadLine();
        }

        static int Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }
    }
}