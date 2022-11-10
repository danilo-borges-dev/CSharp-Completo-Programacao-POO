using Revisando_Enums.Models.Enums;

namespace Revisando_Enums.Models
{
    internal class Order
    {
        public int Id { get; private set; } = new int();
        public double Valor { get; private set; } = new double();
        public Status OrderStatus { get; set; }

        public Order(int id, double valor, Status orderStatus)
        {
            Id = id;
            Valor = valor;
            OrderStatus = orderStatus;
        }

        public override string ToString()
        {
            return $"{Id}, {Valor}, {OrderStatus}";
        }
    }
}
