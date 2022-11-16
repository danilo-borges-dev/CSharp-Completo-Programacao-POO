using Exercicio_63.Models;
using System.Globalization;

int qtdProducts = new int();
char productOrigin = new char();
string nameProduct;
double priceProduct = new double();
double customFee = new double();
DateTime manufactureDate = new DateTime();

Console.Write("Enter the numbers of products: ");
qtdProducts = int.Parse(Console.ReadLine());

List<Product> productList = new List<Product>();

for (int i = 0; i < qtdProducts; i++)
{
    Console.WriteLine($"\nProduct #{i + 1} data: ");
    Console.Write("Common, used or imported (c/u/i)? ");
    productOrigin = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    nameProduct = Console.ReadLine();
    Console.Write("Price: $ ");
    priceProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (productOrigin == 'i' || productOrigin == 'I')
    {
        Console.Write("Customs fee $ ");
        customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        productList.Add(new ImportedProduct(nameProduct, priceProduct, customFee));
    }
    else if (productOrigin == 'u' || productOrigin == 'U')
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