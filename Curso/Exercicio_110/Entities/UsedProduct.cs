using System.Globalization;
using System.Text;

namespace Exercicio_110.Entities
{
    internal sealed class UsedProduct : Product
    {
        public DateTime Manufacture { get; private set; }
        public UsedProduct(string name, double price, DateTime manufacture) : base (name, price)
        {
            Manufacture = manufacture;
        }
        public override string PriceTag()
        {
            StringBuilder sb = new();
            sb.Append($"{this.Name} (used)");
            sb.Append($" $ {this.Price.ToString("F2", CultureInfo.InvariantCulture)}");
            sb.AppendLine($" (Manufacture date: {Manufacture.ToString("dd/MM/yyyy")}) ");
            return sb.ToString();   
        }
    }
}
