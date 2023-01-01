using System.Globalization;

namespace Exercicio_105.Entities
{
    internal class Invoice
    {
        public double BasicPayment { get; private set; }
        public double Tax { get; private set; }
        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }
        public double TotalPayment()
        {
            return BasicPayment + Tax;
        }
        public override string ToString()
        {
            return $"Basic payment $ {BasicPayment.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"Tax $ {Tax.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"Total payment $ {TotalPayment().ToString("F2", CultureInfo.InvariantCulture)}\n";
        }
    }
}
