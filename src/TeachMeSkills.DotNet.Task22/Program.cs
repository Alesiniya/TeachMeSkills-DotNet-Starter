using System;

namespace TeachMeSkills.DotNet.Task22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the credit amount ");
            double credit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the payment amount ");
            double payment = Convert.ToDouble(Console.ReadLine());
            double remainder = credit - payment;
            Banking(payment, credit, remainder);
            Console.WriteLine("Credit balance: {0}", remainder);
            Console.ReadKey();
        }

        static void Banking(double payment, double credit, double remainder)
        {

            if (remainder == 0)
            {
                Console.WriteLine(" Credit repaid");
            }
            else if ( payment > credit)
            {
                Console.WriteLine("Overpayment: {0}", remainder);
            }
            else if (payment < credit)
            {
                Console.WriteLine("Left to pay: {0}", remainder);
            }
        }

    }
}