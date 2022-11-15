namespace Ententando_Heranca.Models
{
    internal class BusinesAccount : Account
    {
        public double LoanLimit { get; private set; } = new double();

        public BusinesAccount(int number, double balance, string holder, double loanLimit) : base(number, balance, holder)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
