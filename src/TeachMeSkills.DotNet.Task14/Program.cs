using System;

namespace TeachMeSkills.DotNet.Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i; j++)
                {

                    Console.Write("*");
                }
                Console.WriteLine("*");
            }
            Console.WriteLine("\n");
            int t = 10;
            for (int j = 0; j < t; j++)
            {
                for (int i = 0; i < t; i++)
                {
                    if (j == 0 || j == t - 1) Console.Write("*");
                    else if (i == 0 || i == t - 1) Console.Write("*");
                    else Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            Console.ReadKey();
        }
    }
}
