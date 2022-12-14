namespace Ententando_Heranca.Models
{
    internal class Account
    {
        public int Number { get; protected set; } = new int();
        public double Balance { get; protected set; } = new double();
        public string Holder { get; protected set; }

        public Account(int number, double balance, string holder)
        {
            Number = number;
            Balance = balance;
            Holder = holder;
        }

        public virtual void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount + 5.0;
            }
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
