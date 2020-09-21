using System;

namespace TeachMeSkills.DotNet._Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your experience ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your salary ");
            int s = Convert.ToInt32(Console.ReadLine());
            int b = s * 10 / 100;
            int c = s * 15 / 100;
            int d = s * 25 / 100;
            int f = s * 35 / 100;
            int g = s * 45 / 100;
            int h = s * 50 / 100;
            if (a < 5)
            {
                Console.WriteLine(b);
            }
            else if (a < 10)
            {
                Console.WriteLine(c);
            }
            else if (a < 15)
            {
                Console.WriteLine(d);
            }
            else if (a < 20)
            {
                Console.WriteLine(f);
            }
            else if (a < 25)
            {
                Console.WriteLine(g);
            }
            else if (a >= 25)
            {
                Console.WriteLine(h);
            }
            Console.ReadKey();
        }
    }
}




