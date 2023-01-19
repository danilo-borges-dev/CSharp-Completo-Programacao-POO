using Exercicio_121.Entities;
using Exercicio_121.Entities.Enums;
using static System.Console;
using System.Globalization;

string name = string.Empty;
string email = string.Empty;
DateTime birthDate = new DateTime();
string status = string.Empty;
EOrderStatus orderStatusEnum = new EOrderStatus();
int nOrdersItem = new int();
string productName = string.Empty;
double productPrice = new double();
int quantity = new int();

Order order;

WriteLine("Enter client data: ");
Write("Name: ");
name = ReadLine();
Write("E-mail: ");
email = ReadLine();
Write("Birth date (DD/MM/YYYY): ");
birthDate = DateTime.Parse(ReadLine());
WriteLine("Enter order data: ");
Write("Satus: ");
status = ReadLine();
Enum.TryParse(status, out orderStatusEnum);
Write("Many items to this order? ");
nOrdersItem = int.Parse(ReadLine());

order = new Order(DateTime.Now, orderStatusEnum, new Client(name, email, birthDate));

for (int i = 0; i < nOrdersItem; i++)
{
    WriteLine($"\nEnter #{i + 1} item data: ");
    Write("Product name: ");
    productName = ReadLine();
    Write("Product price $ ");
    productPrice = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
    Write("Quantity: ");
    quantity = int.Parse(ReadLine());

    order.AddItem(new OrdemItem(quantity, productPrice, new Product(productName, productPrice)));
}

WriteLine("\nORDER SUMMARY");
WriteLine(order);
