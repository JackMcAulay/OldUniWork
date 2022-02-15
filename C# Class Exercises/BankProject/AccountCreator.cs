using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    class AccountCreator
    {
        private BankAccount account1;
        private BankAccount account2;

        public void RunProgram()
        {
            account1 = new BankAccount();
            account2 = new BankAccount("Savings", 35.5);

            Console.WriteLine($"Details of account1 : Name is {account1.Name} and Balance is {account1.Bal}");
            Console.WriteLine($"Details of account1 : Name is {account2.Name} and Balance is {account2.Bal}");

            account2.Deposit(20.0);

            Console.WriteLine($"Details of account1 : Name is {account2.Name} and Balance is {account2.Bal}");

            account2.Deposit(-10.0);

            Console.WriteLine($"Details of account1 : Name is {account2.Name} and Balance is {account2.Bal}");

            account2.Withdraw(15.0);

            Console.WriteLine($"Details of account1 : Name is {account2.Name} and Balance is {account2.Bal}");

            account2.Withdraw(-20.0);

            Console.WriteLine($"Details of account1 : Name is {account2.Name} and Balance is {account2.Bal}");
        }


        static void Main(string[] args)
        {

            AccountCreator myAccountCreator = new AccountCreator();
            myAccountCreator.RunProgram();


            Console.WriteLine("\n\n===============================");
            Console.WriteLine("AccountCreator: Press any key to finish");
            Console.ReadKey();

        }
    }
}
