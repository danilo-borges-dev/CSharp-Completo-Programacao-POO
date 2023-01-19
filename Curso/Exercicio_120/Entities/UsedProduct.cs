using System.Globalization;
using System.Text;

namespace Exercicio_120.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime Manufacture { get; private set; } = new DateTime();

        public UsedProduct(string name, double price, DateTime manufacture): base (name, price)
        {
            Manufacture = manufacture;
        }
        public override string PriceTag()
        {
            StringBuilder sb = new();
            sb.Append($"{Name} (used) ");
            sb.Append($"$ {Price.ToString("F2", CultureInfo.InvariantCulture)} ");
            sb.AppendLine($"(Manufacture date: ({Manufacture.ToString("dd/MM/yyyy")})");
            return sb.ToString();
        }
    }
}
