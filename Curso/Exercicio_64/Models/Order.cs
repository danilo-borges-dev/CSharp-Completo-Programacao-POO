using Exercicio_64.Models.Enums;
using System.Globalization;
using System.Text;

namespace Exercicio_64.Models
{
    internal class Order
    {
        public DateTime Moment { get; private set; } = new DateTime();
        public OrderStatus OrderStatus { get; private set; } = new OrderStatus();
        public Client Client { get; private set; }

        List<OrderItem> OrderList = new List<OrderItem>();

        public Order(DateTime moment, OrderStatus orderStatus, Client client)
        {
            Moment = moment;
            OrderStatus = orderStatus;
            Client = client;
        }

        public void AddItem(OrderItem order)
        {
            OrderList.Add(order);
        }
        public void RemoveItem(OrderItem order)
        {
            OrderList.Remove(order);
        }

        public double Total()
        {
            double result = new double();

            foreach (OrderItem orderItem in OrderList)
            {
                result += orderItem.SubTotal();
            }

            return result;
        }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString());
            sb.Append("Order status: ");
            sb.AppendLine(OrderStatus.ToString());
            sb.Append("Client: ");
            sb.Append(Client.Name);
            sb.Append(" (");
            sb.Append(Client.BirthDate.ToString("dd/MM/yyyy"));
            sb.Append(") - ");
            sb.AppendLine(Client.Email);
            sb.AppendLine("Order Items: ");

            foreach (OrderItem item in OrderList)
            {
                sb.Append(item.Product.Name);
                sb.Append(", $");
                sb.Append(item.Product.Price.ToString("F2", CultureInfo.InvariantCulture));
                sb.Append(" Quantity: ");
                sb.Append(item.Quantity);
                sb.Append(", ");
                sb.Append(" Subtotal: $");
                sb.AppendLine(item.SubTotal().ToString("F2", CultureInfo.InvariantCulture));
            }
            sb.Append("Total price: $");
            sb.AppendLine(Total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
