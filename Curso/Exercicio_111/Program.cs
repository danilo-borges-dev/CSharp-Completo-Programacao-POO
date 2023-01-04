using Exercicio_111.Entities;
using Exercicio_111.Entities.Enums;
using System.Globalization;

Order order;

Console.WriteLine("Enter client data: ");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("E-mail: ");
string email = Console.ReadLine();
Console.Write("Birth date (DD/MM/YYYY): ");
DateTime birthDate = DateTime.Parse(Console.ReadLine());
Console.WriteLine("Order data: ");
Console.Write("Status: ");
string status = Console.ReadLine();
OrderStatus orderStatus = new OrderStatus();
Enum.TryParse(status, out orderStatus);
Console.Write("How many items to this order? ");
int nItems = int.Parse(Console.ReadLine());

order = new Order(DateTime.Now, orderStatus, new Client(name, email, birthDate));

for (int i = 0; i < nItems; i++)
{
    Console.WriteLine($"\nEnter #{i + 1} item data: ");
    Console.Write("Product name: ");
    string productName = Console.ReadLine();
    Console.Write("Product price $ ");
    double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Quantity: ");
    int quantity = int.Parse(Console.ReadLine());

    order.AddItem(new OrderItem(quantity, productPrice, new Product(name, productPrice)));
}

Console.WriteLine($"\nORDER SUMMARY: ");
Console.WriteLine(order);