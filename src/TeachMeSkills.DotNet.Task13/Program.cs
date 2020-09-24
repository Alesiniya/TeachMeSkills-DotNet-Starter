using System;

namespace TeachMeSkills.DotNet.Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number that is greater than the first number ");
            int b = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            for (int i = a + 1; i < b; i++)
            {
                s += i;
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
