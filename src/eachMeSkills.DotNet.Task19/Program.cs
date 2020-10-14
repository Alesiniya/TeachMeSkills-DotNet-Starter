using System;

namespace eachMeSkills.DotNet.Task19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your 1 number ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your 2 number ");
            int b = Convert.ToInt32(Console.ReadLine());
            bool s = false;
            if (a < b)
            {
                for (int i = a; i <= b; i++)
                {
                    s = true;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            s = false;
                            break;
                        }
                    }
                    if (s)
                        Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}