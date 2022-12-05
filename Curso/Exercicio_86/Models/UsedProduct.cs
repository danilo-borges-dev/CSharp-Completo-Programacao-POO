using System.Globalization;
using System.Text;

namespace Exercicio_86.Models
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; private set; } = new DateTime();

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }
        public override string PriceTag()
        {
            StringBuilder sb = new();
            sb.Append(Name);
            sb.Append(" (used) $ ");
            sb.Append(Price.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append($" (Manufacture date: {ManufactureDate.ToString("dd/MM/yyyy")})");
            return sb.ToString();
        }
    }
}
