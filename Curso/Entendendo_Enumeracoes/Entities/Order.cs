using Entendendo_Enumeracoes.Entities.Enums;

namespace Entendendo_Enumeracoes.Entities
{
    internal class Order
    {
        public int Id { get; private set; } = new int();
        public DateTime Moment { get; private set; }
        public OrderStatus Status { get; private set; }

        public Order(int id, DateTime moment, OrderStatus status)
        {
            Id = id;
            Moment = moment;
            Status = status;
        }

        public override string ToString()
        {
            return $"{Id}, {Moment}, {Status}";
        }
    }
}
