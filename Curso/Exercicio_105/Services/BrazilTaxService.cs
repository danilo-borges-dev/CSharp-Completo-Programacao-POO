namespace Exercicio_105.Services
{
    internal class BrazilTaxService
    {
        public double Tax(double amount)
        {
            if (amount <= 100.0)
            {
                return amount * 0.2;
            }
            return amount * 0.15;
        }
    }
}
