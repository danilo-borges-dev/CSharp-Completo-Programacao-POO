using Exercicio_102.Exceptions;
using System.Globalization;

namespace Exercicio_102.Entities
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
        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new InvalidValueException($"Deposit Error: Value {amount.ToString("F2", CultureInfo.InvariantCulture)} is Invalid.");
            }
            Balance += amount;
        }
        public void WithDraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new InvalidValueException($"Withdraw Error: Ammount $ {amount.ToString("F2", CultureInfo.InvariantCulture)} exceeds withdraw limit.");
            }

            if (amount > Balance)
            {
                throw new InvalidValueException($"Withdraw Error: Ammount $ {amount.ToString("F2", CultureInfo.InvariantCulture)} exceeds balance $ {Balance.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            Balance -= amount;
        }
    }
}
