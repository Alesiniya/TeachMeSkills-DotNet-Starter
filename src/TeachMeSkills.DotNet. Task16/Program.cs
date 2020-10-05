using System;

namespace TeachMeSkills.DotNet._Task16
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 20;
            int w = 10;
            for (int f = 0; f < w; f++)
            {
                for (int i = 0; i < s; i++)
                {
                    if (f == 0 || f == w - 1) Console.Write("*");
                    else if (i == 0 || i == s - 1) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine("");
            }
        }
    }
}