using System;

namespace TeachMeSkills.DotNet._Task20
{
    class Program
    {
        public static void Main(string[] args)
        {
            Calculate();
            Console.ReadKey();
        }

        private static void Calculate()
        {
            Console.WriteLine("Enter your 1 number ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your 2 number ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your 3 number ");
            double c = Convert.ToDouble(Console.ReadLine());
            double s = (a + b + c) / 3;
            Console.WriteLine("Arithmetic mean");
            Console.WriteLine(s);
        }
    }
}