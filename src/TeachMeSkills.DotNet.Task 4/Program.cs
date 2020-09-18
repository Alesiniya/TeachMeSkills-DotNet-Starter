using System;

namespace TeachMeSkills.DotNet.Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal h = 3M;
            decimal r = 14M;
            decimal pi = 3.141592653M;
            var V = pi * r * h*2;
            var S = 2 *pi * r * (r+h);
            Console.WriteLine(V);
            Console.WriteLine(S);
            Console.ReadLine();

        }
    }
}
