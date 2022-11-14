using Exercicio_54.Models;
using Exercicio_54.Models.Enums;
using System.Globalization;

string clientName;
string clientEmail;
int statusOrder = new int();
int qtdItems = new int();
string produtcName;
double productPrice = new double();
OrderStatus orderStatus = new OrderStatus();
DateTime birthDate = new DateTime();

Client client;
Order order;

Console.WriteLine("Enter Client Data: ");

Console.Write("Name: ");
clientName = Console.ReadLine();
Console.Write("Email: ");
clientEmail = Console.ReadLine();
Console.Write("Birth Date (DD/MM/YYYY): ");
birthDate = DateTime.Parse(Console.ReadLine());

client = new Client(clientName, clientEmail, birthDate);

Console.WriteLine("\nEnter order data (1 - Pending Payment | 2 - Processing | 3 - Shipped | 4 - Delivered ) : ");
statusOrder = int.Parse(Console.ReadLine());

if (statusOrder == 1)
{
    orderStatus = OrderStatus.Pending_Payment;
}
else if (statusOrder == 2)
{
    orderStatus = OrderStatus.Processing;
}
else if (statusOrder == 3)
{
    orderStatus = OrderStatus.Shipped;
}
else
{
    orderStatus = OrderStatus.Delivered;
}

order = new Order(DateTime.Now, orderStatus, client);

Console.Write("How many items to this order? ");
qtdItems = int.Parse(Console.ReadLine());

for (int i = 0; i < qtdItems; i++)
{
    Console.Write($"\nEnter #{i + 1} item data: ");
    Console.Write("Product name: ");
    produtcName = Console.ReadLine();
    Console.Write("Produtc price: ");
    productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Quantity: ");
    qtdItems = int.Parse(Console.ReadLine());

    order.AddItem(new OrderItem(qtdItems, productPrice, new Product(produtcName, productPrice)));
}