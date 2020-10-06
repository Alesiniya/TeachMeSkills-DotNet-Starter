using System;

namespace TeachMeSkills.DotNet._Task_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount in dollars");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the rate to convert to euro");
            double b = Convert.ToDouble(Console.ReadLine());
            double c = a * b;
            Console.WriteLine("Your currency amount in euros is ");
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
