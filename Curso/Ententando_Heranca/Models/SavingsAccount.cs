namespace Ententando_Heranca.Models
{
    internal class SavingsAccount : Account
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

        public override void Withdraw(double amount)
        {
            Balance -= amount;
        }
    }
}
