using System.Globalization;
using System.Text;

namespace Exercicio_96.Entities
{
    internal sealed class ImportedProduct : Product
    {
        public double CustomsFee { get; private set; }
       
        public ImportedProduct (string name, double price, double customsFee) : base (name, price)
        {
            CustomsFee = customsFee;
        }
        public double TotalPrice()
        {
            return CustomsFee + Price;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new();
            sb.Append($"{Name}");
            sb.Append($" $ {TotalPrice().ToString("F2", CultureInfo.InvariantCulture)}");
            sb.Append($" (Customs fee $ {CustomsFee})");
            return sb.ToString();
        }
    }
}
