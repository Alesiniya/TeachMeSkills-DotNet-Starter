using System;

namespace TeachMeSkills.DotNet._Task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the degree to which you want to raise 2");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a <=32)
            {
                Console.WriteLine("You can raise 2 into this degree");
            }
            else if (a >= 33 || a < 0)
            {
                Console.WriteLine("you can not raise 2 into this degree");
            }
            Console.ReadKey();
        }
    }
}
