using Exercicio_64.Models;
using Exercicio_64.Models.Enums;
using System.Globalization;

string nameClient;
string clientEmail;
DateTime birthDate = new DateTime();
OrderStatus orderStatus = new OrderStatus();
string statusOrder;
int qtdItems = new int();
string productName;
double productPrice = new double();
int productQuantity = new int();

Order oder;

Console.WriteLine("Enter client data: ");
Console.Write("Name: ");
nameClient = Console.ReadLine();
Console.Write("E-mail: ");
clientEmail = Console.ReadLine();
Console.Write("Birth date (DD/MM/YYYY): ");
birthDate = DateTime.Parse(Console.ReadLine());
Console.WriteLine("\nEnter order data: ");
Console.Write("Satus: ");
statusOrder = Console.ReadLine();
Enum.TryParse(statusOrder, out orderStatus);  // Conversão de uma String para um Tipo Enum.

oder = new(DateTime.Now, orderStatus, new Client(nameClient, clientEmail, birthDate));

Console.Write("\nHow many items to this order? ");
qtdItems = int.Parse(Console.ReadLine());

for (int i = 0; i < qtdItems; i++)
{
    Console.Write($"Enter #{i + 1} item data: ");
    Console.Write("Product name: ");
    productName = Console.ReadLine();
    Console.Write("Product Price $ ");
    productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Quantity: ");
    productQuantity = int.Parse(Console.ReadLine());

    oder.AddItem(new OrderItem(productQuantity, productPrice, new Product(productName, productPrice)));
}

Console.WriteLine("\nORDER SUMMARY: ");
Console.WriteLine(oder);