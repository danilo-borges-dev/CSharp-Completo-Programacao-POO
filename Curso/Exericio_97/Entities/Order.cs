using Exericio_97.Entities.Enums;
using System.Globalization;
using System.Text;

namespace Exericio_97.Entities
{
    internal class Order
    {
        public DateTime Moment { get; private set; }
        public OrderStatus Status { get; private set; }
        public Client Client { get; private set; }

        public List<OrdemItem> OrderList = new List<OrdemItem>();

        public Order(DateTime moment, Client client, OrderStatus status)
        {
            Moment = moment;
            Client = client;
            Status = status;
        }

        public void AddOrder(OrdemItem order)
        {
            OrderList.Add(order);
        }
        public void RemoveOrder(OrdemItem order)
        {
            OrderList.Remove(order);
        }
        public double Total()
        {
            double total = new double();
            foreach (OrdemItem order in OrderList)
            {
                total += order.SubTotal();
            }
            return total;
        }
        public override string ToString()
        {
            double totalPrice = new double();
            StringBuilder sb = new();
            foreach (OrdemItem item in OrderList)
            {
                sb.Append($"{item.Product.Name},");
                sb.Append($" Quantity {item.Quantity},");
                sb.AppendLine($" Subtotal $ {item.SubTotal().ToString("F2", CultureInfo.InvariantCulture)}");
                totalPrice += item.SubTotal();
            }
            sb.AppendLine($"Total price $ {totalPrice.ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}
