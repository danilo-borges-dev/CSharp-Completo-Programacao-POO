using System.Text;

namespace Exercicio_63.Models
{
    internal class Products
    {
        public string Name { get; private set; }
        public double Price { get; private set; } = new double();

        public string PriceTag()
        {
            StringBuilder sb = new();

            return sb.ToString();
        }
    }
}
