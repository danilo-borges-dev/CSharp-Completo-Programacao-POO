using Exercicio_87.Models.Enums;
using System.Globalization;
using System.Text;

namespace Exercicio_87.Models
{
    internal class Order
    {
        public DateTime Moment { get; private set; } = new DateTime();
        public OrderStatus OrderStatus { get; private set; } = new OrderStatus();
        public Client Client { get; set; }

        private  List<OrderItem> _items = new List<OrderItem>();
        public Order(DateTime moment, OrderStatus orderStatus, Client client)
        {
            Moment = moment;
            OrderStatus = orderStatus;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            _items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            _items.Remove(item);
        }

        public double Total()
        {
            double total = new double();
            foreach (OrderItem item in _items)
            {
                total += item.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Order moment: {Moment.ToString()}");
            sb.AppendLine($"Order Status: {OrderStatus}");
            sb.AppendLine($"Client: {Client.Name} ({Client.BirthDate.ToString("dd/MM/yyyy")}) - {Client.Email}");
            sb.AppendLine("Order items: ");
            foreach (OrderItem item in _items)
            {
                sb.AppendLine($"{item.Product.Name}, Quantaty: {item.Quantity}, $ {item.Product.Price.ToString("F2", CultureInfo.InvariantCulture)}, Subtotal $ {item.SubTotal().ToString("F2", CultureInfo.InvariantCulture)}");
            }
            sb.AppendLine($"Total Price $ {Total().ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}
