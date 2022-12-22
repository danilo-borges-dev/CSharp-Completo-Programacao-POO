using System.Globalization;
using System.Text;

namespace Exercicio_96.Entities
{
    internal sealed class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; private set; }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base (name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new();
            sb.Append(Name);
            sb.Append($" (used) $ {Price.ToString("F2", CultureInfo.InvariantCulture)}");
            sb.Append($" (Manufacture date: {ManufactureDate.ToString("dd/MM/yyyy")})");
            return sb.ToString();
        }
    }
}
