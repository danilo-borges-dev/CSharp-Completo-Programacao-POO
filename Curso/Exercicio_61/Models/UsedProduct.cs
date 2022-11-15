using System.Globalization;
using System.Text;

namespace Exercicio_61.Models
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; private set; } = new DateTime();

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public sealed override string PriceTag()
        {
            StringBuilder sb = new();
            sb.AppendLine("PRICE TAGS: ");
            sb.Append(Name);
            sb.Append(" (used) ");
            sb.Append(" $ ");
            sb.Append(Price.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append(" (Manufacture date: ");
            sb.Append(ManufactureDate.ToString("dd/MM/yyyy"));
            sb.AppendLine(")");
            return sb.ToString();
        }
    }
}
