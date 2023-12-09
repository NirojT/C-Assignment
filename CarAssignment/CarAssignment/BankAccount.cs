using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssignment
{
    public class BankAccount
    {

        private string accountNumber; 
	    private decimal balance = 0;

        public BankAccount(string accountNumber)
        {
            this.accountNumber = accountNumber;
        }

        public void Depostit(decimal amount)
        {

          /*  balance=amount+balance;*/
            balance += amount;
        }

        public void WithDraw(decimal amount) {

            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"{amount} is deducted from your account and your balance is {balance}");
                return;
            }
            Console.WriteLine("inSufficient fund...");
        }
 public decimal getBalance()
    {
        return this.balance;
    }

    public void setBalance(decimal balance)
    {
        this.balance = balance;
    }
    }
   
}
