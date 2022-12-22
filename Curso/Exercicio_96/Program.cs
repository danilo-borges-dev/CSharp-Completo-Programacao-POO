using Exercicio_96.Entities;
using System.Globalization;

int nProducts = new int();
char originProduct = new char();
string name;
double productPrice = new double();
double customFee = new double();
DateTime manufactureDate = new DateTime();

List<Product> products = new List<Product>();

Console.Write("Enter the number of products: ");
nProducts = int.Parse(Console.ReadLine());

for (int i = 0; i < nProducts; i++)
{
    Console.WriteLine($"\nProduct #{i + 1} data:");
    Console.Write("Common, used or imported (c/u/i): ");
    originProduct = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    name = Console.ReadLine();
    Console.Write("Price: ");
    productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (originProduct == 'i' || originProduct == 'I')
    {
        Console.Write("Customs fee $ ");
        customFee = double.Parse(Console.ReadLine());
        products.Add(new ImportedProduct(name, productPrice, customFee));
    }

    if (originProduct == 'u' || originProduct == 'U')
    {
        Console.Write("Manufacture date (DD/MM/YYYY): ");
        manufactureDate = DateTime.Parse(Console.ReadLine());
        products.Add(new UsedProduct(name, productPrice, manufactureDate));
    }

    if (originProduct == 'c' || originProduct == 'C')
    {
        products.Add(new Product(name, productPrice));
    }
}

Console.WriteLine("\nPRICE TAGS:");
foreach (Product product in products)
{
    Console.WriteLine(product.PriceTag());
}