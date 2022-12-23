namespace Exericio_97.Entities
{
    internal class OrdemItem
    {
        public int Quantity { get; private set; }
        public double Price { get; private set; }
        public Product Product {get; set;}
        public OrdemItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }
        public double SubTotal ()
        {
            return Price * Quantity;
        }
    }
}
