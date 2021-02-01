using System;

namespace Budget
{
    public class AccountName
    {
        public string _accountName;
        public string GetAccountName ()
        {
            Console.Write("Enter your account name: ");
            string _accountName = Console.ReadLine();

            return _accountName;
        }
    }
}
