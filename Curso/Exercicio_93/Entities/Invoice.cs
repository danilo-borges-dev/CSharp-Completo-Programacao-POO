namespace Exercicio_93.Entities
{
    internal class Invoice
    {
        public double BasicPayment { get; private set; } = new double();
        public double Tax { get; private set; } = new double();
        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }
        public double TotalPayment()
        {
            return BasicPayment * Tax;
        }
    }
}
