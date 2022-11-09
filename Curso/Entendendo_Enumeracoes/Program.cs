using Entendendo_Enumeracoes.Entities;
using Entendendo_Enumeracoes.Entities.Enums;

Order order = new(10, DateTime.Now, OrderStatus.PendingPayment);


Console.WriteLine(order);


string txt = OrderStatus.Deliverd.ToString();
Console.WriteLine(txt);



OrderStatus odr;
Enum.TryParse("Shippe", out odr);

Console.WriteLine(odr);

if (odr == OrderStatus.Shipped)
{
    Console.WriteLine("Sim");
}