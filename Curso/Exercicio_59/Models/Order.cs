using Exercicio_54.Models.Enums;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Exercicio_54.Models
{
    internal class Order
    {
        public DateTime Moment { get; private set; } = new DateTime();
        public OrderStatus Status { get; private set; } = new OrderStatus();

        public Client Client { get; private set; }

        List<OrderItem> OrderItemList = new List<OrderItem>();

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            OrderItemList.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            OrderItemList.Remove(item);
        }

        public double Total()
        {
            double total = new double();

            foreach (OrderItem order in OrderItemList)
            {
                total += order.SubTotal();
            }

            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new();

            sb.AppendLine("ORDER SUMMARY:");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString());
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.Append(Client.Name);
            sb.Append(" (");
            sb.Append(Client.BirthDate.ToString("dd/MM/yyyy"));
            sb.Append(") - ");
            sb.AppendLine(Client.Email);

            sb.AppendLine("Order items: ");
            foreach (OrderItem order in OrderItemList)
            {
                sb.Append(order.Product.Name);
                sb.Append(", Quantity: ");
                sb.Append(order.Quantity);
                sb.Append(", Subtotal: $");
                sb.AppendLine(order.SubTotal().ToString("F2", CultureInfo.InvariantCulture));
            }
            sb.Append("Total price: $");
            sb.AppendLine(Total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
