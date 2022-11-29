using Exercicio_83.Models.Exceptions;
using System.Globalization;

namespace Exercicio_83.Models
{
    internal class ContaBancaria
    {
        public int Number { get; private set; } = new int();
        public string Holder { get; private set; }
        public double Balance { get; private set; } = new double();
        public double WithdrawLimit { get; private set; } = new double();

        public ContaBancaria(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Deposit(balance);
            WithdrawLimit = withdrawLimit;
        }
        public void Deposit(double amount)
        {
            if (amount < 0)
            {
                throw new NegativeValueExcetion("Error: Value doe's negative.");
            }
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (amount < 0)
            {
                throw new NegativeValueExcetion("Error: Value doe's negative.");
            }

            if (amount > WithdrawLimit)
            {
                throw new NegativeValueExcetion($"Error: Withdraw limit is {WithdrawLimit.ToString("F2", CultureInfo.InvariantCulture)}");
            }

            if (amount > Balance)
            {
                throw new NegativeValueExcetion($"Error: Balance value is {Balance.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            Balance -= amount;
        }
    }
}
