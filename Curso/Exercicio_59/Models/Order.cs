using Exercicio_54.Models.Enums;
using System.Reflection.Metadata.Ecma335;

namespace Exercicio_54.Models
{
    internal class Order
    {
        public DateTime Moment { get; private set; } = new DateTime();
        public OrderStatus Status { get; private set; } = new OrderStatus();

        Client client = null;

        List<OrderItem> OrderItemList = new List<OrderItem>();

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            this.client = client;
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
    }
}
