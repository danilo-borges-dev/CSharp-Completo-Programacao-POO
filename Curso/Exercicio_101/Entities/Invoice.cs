using System.Globalization;

namespace Exercicio_101.Entities
{
    internal class Invoice
    {
        public double BasePayment { get; private set; }
        public double Tax { get; private set; }

        public Invoice(double basePayment, double tax)
        {
            BasePayment = basePayment;
            Tax = tax;
        }   
        public double TotalPayment()
        {
            return BasePayment + Tax;
        }

        public override string ToString()
        {
            return $"\nBasic payment: $ {BasePayment.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"Tax: $ {Tax.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"Total payment $ {TotalPayment().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
