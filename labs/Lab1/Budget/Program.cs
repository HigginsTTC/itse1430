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
        string accountName;
        private static string startingBalance;

        static void Main()
        {
            DisplayProgramInformation();
            DisplayWelcomeMessage();

            AccountName name = new AccountName();
            Console.Write("Enter your account name: ");
            string accountName = Console.ReadLine();

            Console.WriteLine("You entered \"" + accountName + "\" for your account name.\n");

            AccountNumber number = new AccountNumber();
            Console.Write("Enter your account Number: ");
            string accountNumber = Console.ReadLine();

            Console.WriteLine("You entered \"" + accountNumber + "\" for your account number.\n");

            StartingBalance balance = new StartingBalance();
            Console.Write("Enter you starting balance: ");
            decimal startingBalance = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("Your entered \"" + startingBalance + "\" for your starting balance.\n");

        }
        public static void DisplayProgramInformation()
        {
            Console.WriteLine("Budget");
            Console.WriteLine("ITSE 1430");
            Console.WriteLine("Spring 2021");
            Console.WriteLine("Debbie Higgins");
            Console.WriteLine("--------------------");
        }

        public static void DisplayWelcomeMessage()
        {
            Console.Write("Thank you for selecting Sybbie's Wonderful Budget. ");
            Console.WriteLine("Let's get started.");
        }


    }
}
