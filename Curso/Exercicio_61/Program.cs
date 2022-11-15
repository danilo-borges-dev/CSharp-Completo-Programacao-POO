using Exercicio_61.Models;
using System.Globalization;

int qtdProducts = new int();
char origenProduct = new char();
double productPrice = new double();
double customsFee = new double();
DateTime productDataProduction = new DateTime();
string productName;

List<Product> productList = new List<Product>();

Console.Write("Enter the number of products: ");
qtdProducts = int.Parse(Console.ReadLine());

for (int i = 0; i < qtdProducts; i++)
{
    Console.Write($"\nProduct #{i + 1} data: ");
    Console.Write("Common, used or imported (c/u/i)? ");
    origenProduct = char.Parse(Console.ReadLine());

    Console.Write("Name: ");
    productName = Console.ReadLine();
    Console.Write("Price $ ");
    productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (origenProduct == 'i' || origenProduct == 'I')
    {
        Console.Write("Customs fee: ");
        customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        productList.Add(new ImportedProduct(productName, productPrice, customsFee));
    }
    else if (origenProduct == 'u' || origenProduct == 'U')
    {
        Console.Write("Manufacture date (DD/MM/YYYY): ");
        productDataProduction = DateTime.Parse(Console.ReadLine());

        productList.Add(new UsedProduct(productName, productPrice, productDataProduction));
    }
    else
    {
        productList.Add(new Product(productName, productPrice));
    }    
}

Console.WriteLine("PRICE TAGS:");

foreach (Product product in productList)
{
    Console.WriteLine(product.PriceTag());
}
