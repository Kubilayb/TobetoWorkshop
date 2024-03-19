using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Examples._5_Encapsulation
{
    public class BankAccount
    {
        private string customerName;
        private string accountNumber;
        private decimal balance;

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public string AccountNumber
        {
            get { return accountNumber; }
            private set { accountNumber = value; }
        }

        public decimal Balance
        {
            get { return balance; }
            private set { balance = value; }
        }

        public BankAccount(string customerName, string accountNumber, decimal initialBalance)
        {
            this.customerName = customerName;
            this.accountNumber = accountNumber;
            this.balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"{amount} deposited. Current balance: {balance}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"{amount} withdrawn. Current balance: {balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient balance.");
            }
        }
    }

}
