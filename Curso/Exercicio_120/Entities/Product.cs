using System.Globalization;
using System.Text;

namespace Exercicio_120.Entities
{
    internal class Product
    {
        public string Name { get; protected set; } = string.Empty;
        public double Price { get; protected set; } = new double();
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public virtual string PriceTag ()
        {
            StringBuilder sb = new();
            sb.AppendLine($"{Name} $ {Price.ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}
