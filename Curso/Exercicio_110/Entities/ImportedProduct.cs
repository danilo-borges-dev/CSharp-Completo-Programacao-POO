using System.Globalization;
using System.Text;

namespace Exercicio_110.Entities
{
    internal sealed class ImportedProduct : Product
    {
        public double CustomFee { get; private set; }
        public ImportedProduct(string name, double price, double customFee) : base (name, price)
        {
            CustomFee = customFee;
        }
        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.Name} ");
            sb.Append($"$ {(this.Price + CustomFee).ToString("F2", CultureInfo.InvariantCulture)} ");
            sb.AppendLine($"(Customs fee: $ {CustomFee.ToString("F2", CultureInfo.InvariantCulture)})");
            return sb.ToString();
        }
    }
}
