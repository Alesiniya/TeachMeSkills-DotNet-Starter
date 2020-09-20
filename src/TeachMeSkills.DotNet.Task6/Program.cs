using System;

namespace TeachMeSkills.DotNet.Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "operand1";
            string b = "operand2";
            var operand1 = 5;
            var operand2 = 10;
            Console.WriteLine("Enter the sign of the arithmetic operation");
            string sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    {
                        Console.WriteLine(operand1 + operand2);
                        break;
                    }

                case "-":
                    {
                        Console.WriteLine(operand2 - operand1);
                        break;
                    }

                case "*":
                    {
                        Console.WriteLine(operand2 * operand1);
                        break;
                    }

                case "/":
                    {
                        Console.WriteLine(operand2 / operand1);
                        break;
                    }
                case "/0":
                    {
                        Console.WriteLine("You cannot divide by zero!");
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}




