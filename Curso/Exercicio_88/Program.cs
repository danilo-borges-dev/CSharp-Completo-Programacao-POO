using Exercicio_88.Models;
using System.Globalization;

int numberTaxPayers = new int();
char individualOrCompany = new char();
double anualIncome = new double();
double healthExpeditures = new double();
int numberOfEmployees = new int();
string name;
double totalValue = new double();

List<Contribuinte> contribuintList = new List<Contribuinte>();

Console.WriteLine("Enter the number os tax payers: ");
numberTaxPayers = int.Parse(Console.ReadLine());

for (int i = 0; i < numberTaxPayers; i++)
{
    Console.WriteLine($"\nTax #{i + 1} data:");
    Console.WriteLine("Name: ");
    name = Console.ReadLine();
    Console.WriteLine("Indidual or company (i/c)?");
    individualOrCompany = char.Parse(Console.ReadLine());
    Console.WriteLine("Anual Income: ");
    anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (individualOrCompany == 'i' || individualOrCompany == 'I')
    {
        Console.WriteLine("Health expeditures: ");
        healthExpeditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        contribuintList.Add(new PessoaFisica(name, anualIncome, healthExpeditures));
    }
    else
    {
        Console.WriteLine("Number os employees: ");
        numberOfEmployees = int.Parse(Console.ReadLine());

        contribuintList.Add(new PessoaJoridica(name, anualIncome, numberOfEmployees));
    }
}

Console.WriteLine("\nTAXES PAID:");
foreach (Contribuinte contribuinte in contribuintList)
{
    totalValue += contribuinte.CalcularImposto();
    Console.WriteLine($"{contribuinte.Nome}: $ {contribuinte.CalcularImposto().ToString("F2", CultureInfo.InvariantCulture)}");
}

Console.WriteLine($"\nTotal Taxes $ {totalValue.ToString("F2", CultureInfo.InvariantCulture)}");