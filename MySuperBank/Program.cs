using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Daniel", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with ${account.Balance}");

            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine($"Your current balance is ${account.Balance}");
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            Console.WriteLine($"Your current balance is ${account.Balance}");

            Console.WriteLine(account.GetAccountHistory());
        }
    }
}
