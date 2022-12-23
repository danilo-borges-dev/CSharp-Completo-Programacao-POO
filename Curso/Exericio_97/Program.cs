using Exericio_97.Entities;
using Exericio_97.Entities.Enums;
using System.Globalization;

string name;
string email;
DateTime birthDate = new DateTime();
int nItems = new int();
string productname;
int quantity = new int();
double price = new double();
int status = new int();
OrderStatus orderStatus = new OrderStatus();

Order order;

Console.WriteLine("Enter client data: ");
Console.Write("Name: ");
name = Console.ReadLine();
Console.Write("E-mail: ");
email = Console.ReadLine();
Console.Write("Birth date (DD/MM/YYYY): ");
birthDate = DateTime.Parse(Console.ReadLine());

Console.WriteLine("Enter order data: ");
Console.Write("Status (1 - Pending Payment/ 2 - Processing / 3 - Shipped / 4 - Delivered): ");
status = int.Parse(Console.ReadLine());

if (status == 1)
{
    orderStatus = OrderStatus.Pending_Payment;
}
else if (status == 2)
{
    orderStatus = OrderStatus.Processing;
}
else if (status == 3)
{
    orderStatus = OrderStatus.Shipped;
}
else
{
    orderStatus = OrderStatus.Delivered;
}

order = new Order(DateTime.Now, new Client(name, email, birthDate), orderStatus);

Console.Write("How many items to this order? ");
nItems = int.Parse(Console.ReadLine());

for (int i = 0; i < nItems; i++)
{
    Console.WriteLine($"\nEnter #{i + 1} item data: ");
    Console.Write("Product name: ");
    productname = Console.ReadLine();
    Console.Write("Price: $ ");
    price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Quantity: ");
    quantity = int.Parse(Console.ReadLine());

    order.AddOrder(new OrdemItem(quantity, price, new Product(productname, price)));
}

Console.WriteLine("\nORDER SUMMARY: ");
Console.WriteLine($"Order moment: {order.Moment.ToString()}");
Console.WriteLine($"Order status: {order.Status.ToString()}");
Console.WriteLine($"Client: {order.Client.Name} ({order.Client.BirthDate.ToString("dd/MM/yyyy")}) - {order.Client.Email}");
Console.WriteLine($"Order items:");
Console.WriteLine(order);