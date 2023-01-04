using Exercicio_110.Entities;
using System.Globalization;

List<Product> productList = new List<Product>();

Console.Write("Enter the number of products: ");
int nProducts = int.Parse(Console.ReadLine());
for (int i = 0; i < nProducts; i++)
{
    Console.WriteLine($"\nProduct #{i + 1} data:");
    Console.Write("Common, used or imported (c/u/i): ");
    char productOrigin = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price $ ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (productOrigin == 'i' || productOrigin == 'I')
    {
        Console.Write("Customs fee: ");
        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        productList.Add(new ImportedProduct(name, price, customsFee));
    }
    else if (productOrigin == 'u' || productOrigin == 'U')
    {
        Console.Write("Manufacture date (DD/MM/YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine());
        productList.Add(new UsedProduct(name, price, date));
    }
    else
    {
        productList.Add(new Product(name, price));
    }
}

Console.WriteLine("\nPRICE TAGS:");
foreach (Product product in productList)
{
    Console.WriteLine(product.PriceTag());
}
