using Exercicio_120.Entities;
using static System.Console;

int nProducts = new int();
char productOrigin = new char();
string productName = string.Empty;
double price = new double();
double customsFee = new double();
DateTime manufactureDate = new DateTime();

List<Product> products = new List<Product>();

Write("Enter the number of products: ");
nProducts = int.Parse(ReadLine());
for (int i = 0; i < nProducts; i++)
{
    WriteLine($"\nProduct #{i + 1} data: ");
    Write("Common, used or impoarted (c/u/i): ");
    productOrigin = char.Parse(ReadLine());
    Write("Name: ");
    productName = ReadLine();
    Write("Price: ");
    price = double.Parse(ReadLine());

    if (productOrigin == 'i' || productOrigin == 'I')
    {
        Write("Customs fee: ");
        customsFee = double.Parse(ReadLine());

        products.Add(new ImportedProduct(productName, price, customsFee));
    }
    else if (productOrigin == 'u' || productOrigin == 'U')
    {
        Write("Manufacture data (DD/MM/YYYY): ");
        manufactureDate = DateTime.Parse(ReadLine());

        products.Add(new UsedProduct(productName, price, manufactureDate));
    }
    else
    {
        products.Add(new Product(productName, price));
    }
}

WriteLine("\nPIRCE TAGS");
foreach (var product in products)
{
    Write(product.PriceTag());
}
