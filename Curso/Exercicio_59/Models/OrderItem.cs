namespace Exercicio_54.Models
{
    internal class OrderItem
    {
        public int Quantity { get; set; } = new int();
        public double Price { get; private set; } = new int();

        public Product Product { get; private set; }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }
    }
}
