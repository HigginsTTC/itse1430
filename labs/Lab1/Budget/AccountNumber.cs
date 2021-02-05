using System;

namespace Budget
{
    public class AccountNumber
    {
        public string _accountNumber;

        public string GetAccountNumber ()
        {
            Console.WriteLine("Before creating a new account number, please consider the following ");
            Console.WriteLine("\tThe account number must consist of only digits (0-9).");
            Console.WriteLine("\tThe account number must be exactly 12 characters long.");
            Console.WriteLine("\tThe account number may not start or end with a zero.");
            Console.WriteLine("Account number example\t 123456123456.");
            Console.Write("Enter your account number: ");
            string _accountNumber = Console.ReadLine();

            //TODO  enter validation for account number
            return _accountNumber;
        }
    }
}
