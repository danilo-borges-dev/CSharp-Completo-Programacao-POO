namespace Exercicio_121.Entities
{
    internal sealed class Product
    {
        public string Name { get; private set; } = string.Empty;
        public double Price { get; private set; } = new double();
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
