using Exercicio_87.Models;
using Exercicio_87.Models.Enums;
using System.Globalization;

string name;
string email;
int status = new int();
int nItems = new int();
DateTime birthDate = new DateTime();
OrderStatus orderStatus = new OrderStatus();
string productName;
double productPrice = new double();
int quantity = new int();

Order order;

Console.Write("Enter client data: ");
Console.Write("Name: ");
name = Console.ReadLine();
Console.Write("E-mail: ");
email = Console.ReadLine();
Console.Write("Birth date (DD/MM/YYYY): ");
birthDate = DateTime.Parse(Console.ReadLine());
Console.WriteLine("Enter order data: ");
Console.Write("Status (1 - Pendding Payment | 2 - Processing | 3 - Shipped | 4 - Delivered): ");
status = int.Parse(Console.ReadLine());

if (status == 1)
{
    Enum.TryParse("PeddingPayment", out orderStatus);
}
else if (status == 2)
{
    Enum.TryParse("Processing", out orderStatus);
}
else if ( status == 3)
{
    Enum.TryParse("Shipped", out orderStatus);
}
else if (status == 4)
{
    Enum.TryParse("Delivered", out orderStatus);
}

order = new(DateTime.Now, orderStatus, new Client(name, email, birthDate));

Console.Write("How many items to this order? ");
nItems = int.Parse(Console.ReadLine());

for (int i = 0; i < nItems; i++)
{
    Console.WriteLine($"Enter #{i + 1} data: ");
    Console.Write("Product name: ");
    productName = Console.ReadLine();
    Console.Write("Product Price $ ");
    productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Quantity: ");
    quantity = int.Parse(Console.ReadLine());

    order.AddItem(new OrderItem(quantity, productPrice, new Product(productName, productPrice)));
}

Console.WriteLine(order);
