using System.Globalization;
using System.Text;

namespace Exercicio_86.Models
{
    internal sealed class ImportedProduct : Product
    {
        public double CustomsFee { get; private set; } = new double();

        public ImportedProduct(string name, double price, double customsFee): base (name, price)
        {
            CustomsFee = customsFee;
        }
        public double TotalPrice()
        {
            return CustomsFee + Price;
        }
        public sealed override string PriceTag()
        {
            StringBuilder sb = new();
            sb.Append(Name);
            sb.Append(" $ ");
            sb.Append(TotalPrice().ToString("F2", CultureInfo.InvariantCulture));
            sb.Append($" (Customs fee: $ {CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})");
            return sb.ToString();
        }
    }
}
