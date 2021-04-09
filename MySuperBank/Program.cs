using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Andrew", 1000m);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");

            account.MakeWithdrawal(100m, DateTime.Now, "PS5");
            account.MakeWithdrawal(200m, DateTime.Now, "PS6");
            account.MakeWithdrawal(300m, DateTime.Now, "PS7");

        }
    }
}
