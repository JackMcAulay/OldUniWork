using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    class BankAccount
    {
        private string AccountName;
        private double Balance;

        public BankAccount()
        {
            AccountName = "no name";
            Balance = 0.0;
        }

        public BankAccount(string accountName, double balance)
        {
            AccountName = accountName;
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0 )
            {
                Balance += amount;
            }
        }
        public void Withdraw(double amount)
        {
            if (amount > 0)
            {
                Balance -= amount;
            }
        }

        public string Name
        {
            set { AccountName = value; }

            get { return AccountName; }
        }

        public double Bal
        {
            set { Balance = value; }

            get { return Balance; }
        }
    }
}
