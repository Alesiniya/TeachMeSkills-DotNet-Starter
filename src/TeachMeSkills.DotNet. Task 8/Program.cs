using System;
using System.Linq;
using System.Collections.Generic;

namespace TeachMeSkills.DotNet._Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a word about the weather in Russian");
            string word = Console.ReadLine();
            if (word=="d") Console.Write("Your translation show");
            else if (word=="hot") Console.Write("Your translation жарко");
            else Console.Write(" ");

            Console.ReadKey();
        }
    }
}