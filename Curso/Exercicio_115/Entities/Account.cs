using Exercicio_115.Exceptions;
using System.Globalization;

namespace Exercicio_115.Entities
{
    internal class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; private set; }
        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Deposit(balance);
            WithdrawLimit = withdrawLimit;
        }
        public void Deposit (double amount)
        {
            if (amount <= 0)
            {
                throw new InvalidAmmountException($"Error: Amount $ {amount.ToString("F2", CultureInfo.InvariantCulture)} invalid for deposit.");
            }
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if(amount > Balance)
            {
                throw new InvalidAmmountException($"Error: Balance value is $ {Balance.ToString("F2", CultureInfo.InvariantCulture)}.");
            }
            if (amount > WithdrawLimit)
            {
                throw new InvalidAmmountException($"Error: Withdraw limit is $ {WithdrawLimit.ToString("F2", CultureInfo.InvariantCulture)}.");
            }
            Balance -= amount;
        }
    }
}
