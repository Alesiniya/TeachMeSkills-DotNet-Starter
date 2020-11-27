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

            string world = Console.ReadLine().ToLower();

            switch (world)
            {
                case "снег":
                    Console.WriteLine("show");
                    break;
                case "жарко":
                    Console.WriteLine("hot");
                    break;
                case "холодно":
                    Console.WriteLine("cold");
                    break;
                case "солнце":
                    Console.WriteLine("sun");
                    break;
                case "дождь":
                    Console.WriteLine("rain");
                    break;
                case "облачно":
                    Console.WriteLine("cloudy");
                    break;
                case "туман":
                    Console.WriteLine("fog");
                    break;
                case "град":
                    Console.WriteLine("hail");
                    break;
                case "давление":
                    Console.WriteLine("pressure");
                    break;
                case "уровень опасности":
                    Console.WriteLine("hazard level");
                    break;
            }
            Console.ReadKey();
        }
    }
}