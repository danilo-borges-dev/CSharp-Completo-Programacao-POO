namespace Exercicio_54.Models
{
    internal class Product
    {
        public string Name { get; private set; }
        public double Price { get; private set; } = new double();

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
