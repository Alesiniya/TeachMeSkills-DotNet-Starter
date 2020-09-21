using System;

namespace TeachMeSkills.DotNet.Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number you want to check");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2==1)
            {
                Console.WriteLine("odd number");

            }
            else
            {
                Console.WriteLine("even number");
            }

            Console.ReadKey();
        }
    }
}
