namespace Ententando_Heranca.Models
{
    internal sealed class SavingsAccount : Account
    {
        public double InterestRate { get; private set; } = new double();

        public SavingsAccount(int number, double balance, string holder, double interestRate) : base (number, balance, holder)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= amount;
        }
    }
}
