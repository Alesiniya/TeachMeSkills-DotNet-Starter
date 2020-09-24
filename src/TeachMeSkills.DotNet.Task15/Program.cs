using System;

namespace TeachMeSkills.DotNet.Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, result = 1, num = 1;

            Console.WriteLine("");
            i = int.Parse(Console.ReadLine());

            Console.Write("{0} = ", i);
            do
            {
                result *= num;
                num++;
            } while (num <= i);
        }
    }
}
