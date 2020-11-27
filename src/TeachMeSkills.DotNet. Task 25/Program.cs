using System;

namespace TeachMeSkills.DotNet._Task_25
{
    class Program
    {
        static void DisplayArray(string[] arr) => Console.WriteLine(string.Join(" ", arr));

        // Change the array by reversing its elements.
        static void ChangeArray(string[] arr) => Array.Reverse(arr);

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
