using System;

namespace TeachMeSkills.DotNet.Task_21
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your 1 number ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your 2 number ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your 3 number ");
            double c = Convert.ToDouble(Console.ReadLine());
            Calculate(a, b, c, out double s, out double f, out double d);
            Console.ReadKey();
        }

        public static void Calculate(double a, double b, double c, out double s, out double f, out double d)
        {
            s = a / 5;
            f = b / 5;
            d = c / 5;
            Console.WriteLine("Division 1 number by 5");
            Console.WriteLine(s);
            Console.WriteLine("Division 2 number by 5");
            Console.WriteLine(f);
            Console.WriteLine("Division 3 number by 5");
            Console.WriteLine(d);

        }
    }
    }