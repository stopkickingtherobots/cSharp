using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Kendra", 10000);

            Console.WriteLine(account.GetAccountHistory());
            Console.WriteLine(account.Balance);

            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}");

            decimal pocketMoney = 5000;
            account.MakeDeposit(pocketMoney, DateTime.Now, "Pocket money.");

            Console.WriteLine($"Add ${pocketMoney} to {account.Number}, owned by {account.Owner}, account balance now {account.Balance}");

            decimal costOfHammock = 2000;
            account.MakeWithdrawal(costOfHammock, DateTime.Now, "Buy hammock.");

            Console.WriteLine($"Purchased hammock for ${costOfHammock} by {account.Owner}, account balance now {account.Balance}");

            Console.WriteLine(account.GetAccountHistory());
            Console.WriteLine(account.Balance);

            // Test that the initial balances must be positive.
            try
            {
                var invalidAccount = new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                // Console.WriteLine(e.ToString());
            }

            decimal movieTicket = 10;
            account.MakeWithdrawal(movieTicket, DateTime.Now, "Gonna see Cats.");
            Console.WriteLine(account.Balance);

            Console.WriteLine(account.GetAccountHistory());
            Console.WriteLine(account.Balance);

        }
    }
}
 