namespace Exercicio_121.Entities
{
    internal sealed class OrdemItem
    {
        public int Quantity { get; private set; } = new int();
        public double Price { get; private set; } = new double();
        public Product? Product { get; private set; } 
        public OrdemItem() { }
        public OrdemItem(int quantity, double price, Product? product)
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
