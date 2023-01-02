using System.Globalization;

namespace Exercicio_107.Entities
{
    internal class Invoice
    {
        public double BasicaPayment { get; private set; }
        public double Tax { get; private set; }
        public Invoice(double basicaPayment, double tax)
        {
            BasicaPayment = basicaPayment;
            Tax = tax;
        }
        public double TotalPayment()
        {
            return BasicaPayment + Tax;
        }
        public override string ToString()
        {
            return $"\nBasic payment $ {BasicaPayment.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"Tax $ {Tax.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"Total payment $ {TotalPayment().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
