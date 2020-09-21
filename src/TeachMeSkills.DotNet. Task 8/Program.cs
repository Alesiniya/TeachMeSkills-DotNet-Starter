using System;

namespace TeachMeSkills.DotNet._Task_8
{
    using System;

    namespace TeachMeSkills.DotNet.Task6
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Enter your world: ");
                string userInput = Console.ReadLine();
                bool result = World.TryParse(userInput, out world);
                if (result)
                {
                    Console.WriteLine(date.DayOfWeek);
                }
                else
                {
                    Console.WriteLine("incorrect input");
                }
                Console.ReadLine();
            }
        }
    }