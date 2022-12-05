using Exercicio_86.Models;
using System.Globalization;

int nProducts = new int();
char option = new char();
double priceProduct = new double();
double customFee = new double();
DateTime manufactureDate = new DateTime();
string nameProduct;

List<Product> productList = new List<Product>();

Console.Write("Enter the number os products: ");
nProducts = int.Parse(Console.ReadLine());

for (int i = 0; i < nProducts; i++)
{
    Console.WriteLine($"\nProduct #{i + 1} data: ");
    Console.Write("Common, used or imported (c/u/i): ");
    option = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    nameProduct = Console.ReadLine();
    Console.Write("Price: ");
    priceProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (option == 'i' || option == 'I')
    {
        Console.Write("Customs fee $ ");
        customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        productList.Add(new ImportedProduct(nameProduct, priceProduct, customFee));
    }
    else if (option == 'u' || option == 'U')
    {
        Console.Write("Manufacture date (DD/MM/YYYY): ");
        manufactureDate = DateTime.Parse(Console.ReadLine());

        productList.Add(new UsedProduct(nameProduct, priceProduct, manufactureDate));
    }
    else
    {
        productList.Add(new Product(nameProduct, priceProduct));
    }
}

Console.WriteLine("\nPRICE TAGS: ");
foreach (Product product in productList)
{
    Console.WriteLine(product.PriceTag());
}
