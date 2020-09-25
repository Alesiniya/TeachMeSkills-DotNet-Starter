using System;

namespace TeachMeSkills.DotNet.Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of possible delivery options");
            int a = Convert.ToInt32(Console.ReadLine());
            int f=1;
            int n = 1;
            do
            {
                f *= n;
                n ++;
            }
            while (n<=a);
            Console.WriteLine(f);
        }
    }
}
