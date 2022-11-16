namespace Exercicio_64.Models
{
    internal class OrderItem
    {
        public int Quantity { get; private set; } = new int();
        public double Price { get; private set; } = new double();
        public Product Product { get; private set; }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }
    }
}
