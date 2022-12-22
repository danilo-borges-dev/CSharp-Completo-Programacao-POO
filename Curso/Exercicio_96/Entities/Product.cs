using System.Globalization;
using System.Text;

namespace Exercicio_96.Entities
{
    internal class Product
    {
        public string Name { get; protected set; }
        public double Price { get; protected set; }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public virtual string PriceTag()
        {
            StringBuilder sb = new();
            sb.Append(Name);
            sb.Append($" $ {Price.ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}
