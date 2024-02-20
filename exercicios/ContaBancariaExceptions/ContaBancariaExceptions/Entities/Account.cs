using ContaBancariaExceptions.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancariaExceptions.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;

            if(amount > Balance)
            {
                throw new DomainException("Error in withdraw: Not enough balance for this withdraw.");
            }

            if(amount > WithdrawLimit)
            {
                throw new DomainException("Error in withdraw: Withdraw limit exceeded.");
            }
        }
    }
}
