using Exercicio_121.Entities.Enums;
using System.Globalization;
using System.Text;

namespace Exercicio_121.Entities
{
    internal class Order
    {
        public DateTime Moment { get; private set; } = new DateTime();
        public EOrderStatus OrderStatus { get; private set; } = new EOrderStatus();
        public Client? Client { get; private set; }
        public List<OrdemItem> OrdemItems { get; private set;} = new List<OrdemItem>();
        public Order() { }  
        public Order(DateTime moment, EOrderStatus orderStatus, Client? client)
        {
            Moment = moment;
            OrderStatus = orderStatus;
            Client = client;
        }

        public void AddItem(OrdemItem item)
        {
            OrdemItems.Add(item);
        }
        public void RemoveItem(OrdemItem item)
        {
            OrdemItems.Remove(item);
        }
        public double Total()
        {
            double total = new double();
            foreach (var item in OrdemItems)
            {
                total += item.SubTotal();
            }
            return total;
        }
        public override string ToString()
        {
            double total = new double();

            StringBuilder sb = new();
            sb.AppendLine($"Order moment: {Moment.ToString()}");
            sb.AppendLine($"Order Status: {OrderStatus}");
            sb.AppendLine($"Client: {Client.Name} ({Client.BrithDate.ToString("dd/MM/yyyy")} - {Client.Email}");
            sb.AppendLine("Order items: ");
            foreach (var item in OrdemItems)
            {
                sb.Append($"{item.Product.Name}, ");
                sb.Append($"$ {item.Product.Price.ToString("F2", CultureInfo.InvariantCulture)}, ");
                sb.Append($"Quantity {item.Quantity}, ");
                sb.AppendLine($"Subtotal: $ {item.SubTotal().ToString("F2", CultureInfo.InvariantCulture)}");
                total += item.SubTotal();
            }
            sb.AppendLine($"Total price: {total.ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}
