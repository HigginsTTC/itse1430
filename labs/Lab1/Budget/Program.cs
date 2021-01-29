/*
 * Budget
 * ITSE 1430
 * Spring 2021
 * Debbie Higgins
 */

using System;

namespace Budget
{
    class Program
    {
       
        static void Main()
        {
            DisplayProgramInformation();
            GetStartingAccount();
        }

        static void GetStartingAccount ()
        {
            Console.Write("Thank you for selecting Sybbie's Wonderful Budget. ");
            Console.WriteLine("Let's get started");

            Console.Write("Please enter your account name:  ");
            string accountName = Console.ReadLine();

            Console.Write("Please enter your Account number:  ");
            string accountNumber = Console.ReadLine();

            Console.Write("Plese enter your starting balance:  ");
            decimal startingBalance =Decimal.Parse(Console.ReadLine());
        }

        static void DisplayProgramInformation ()
        {
            Console.WriteLine("Budget");
            Console.WriteLine("ITSE 1430");
            Console.WriteLine("Spring 2021");
            Console.WriteLine("Debbie Higgins");
            Console.WriteLine("--------------------");
        }
    }
}
