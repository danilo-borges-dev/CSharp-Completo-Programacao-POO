using Exercicio_91.Exceptions;

namespace Exercicio_91.Models
{
    internal class Account
    {
        public int Number { get; private set; } = new int();
        public string Houlder { get; private set; }
        public double Balance { get; private set; } = new double();
        public double WithdrawLimit { get; private set; } = new double();
        public Account(int number, string houlder, double balance, double withdrawLimit)
        {
            Number = number;
            Houlder = houlder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }
        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new AmountInvalidException("Value invalid.");
            }
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > Balance)
            {
                throw new AmountInvalidException("The amount exceeds balance.");
            }

            if (amount > WithdrawLimit)
            {
                throw new AmountInvalidException("The amount exceeds withdraw limit.");
            }
            Balance -= amount;
        }
    }
}
