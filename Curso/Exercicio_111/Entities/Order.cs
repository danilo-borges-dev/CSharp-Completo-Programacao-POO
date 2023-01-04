using Exercicio_111.Entities.Enums;
using System.Globalization;
using System.Text;

namespace Exercicio_111.Entities
{
    internal class Order
    {
        public DateTime Moment { get; private set; }
        public OrderStatus OrderStatus { get; private set; }
        public Client Client { get; private set; }

        public List<OrderItem> Items = new List<OrderItem>();

        public Order(DateTime moment, OrderStatus orderStatus, Client client)
        {
            Moment = moment;
            OrderStatus = orderStatus;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }
        public double Total()
        {
            double total = new double();
            foreach (OrderItem item in Items)
            {
                total += item.SubTotal();
            }
            return total;
        }
        public override string ToString()
        {
            double totalPrice = new double();
            StringBuilder sb = new();
            sb.AppendLine($"Order moment: {Moment.ToString("dd/MM/yyyy")}");
            sb.AppendLine($"Order Status {OrderStatus.ToString()}");
            sb.AppendLine($"Client: {Client.Name} ({Client.BirthDate.ToString("dd/MM/yyyy")}) - {Client.Email}");
            sb.AppendLine($"Order Items: ");
            foreach (OrderItem orderItem in Items)
            {
                sb.Append($"{orderItem.Product.Name}, ");
                sb.Append($"Quantity: {orderItem.Quantity}, ");
                sb.AppendLine($"Subtotal: $ {orderItem.SubTotal().ToString("F2", CultureInfo.InvariantCulture)}");
                totalPrice += orderItem.SubTotal();
            }
            sb.AppendLine($"Total Price: $ {totalPrice.ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}
