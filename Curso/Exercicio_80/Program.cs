using Exercicio_80.Models;
using System.Globalization;

int nPayers = new int();
string name;
double income = new double();
double expenditures = new double();
char individualOrCompany = new char();
int nEmployees = new int();

List<Contribuinte> listaDeContribuintes = new List<Contribuinte>();

Console.Write("Enter the number of tax payers: ");
nPayers = int.Parse(Console.ReadLine());

for (int i = 0; i < nPayers; i++)
{
    Console.WriteLine($"\nTax payer #{i + 1} data:  ");
    Console.Write("Individual or company (i/c)? ");
    individualOrCompany = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    name = Console.ReadLine();    
    Console.Write("Anual income: ");
    income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (individualOrCompany == 'i' || individualOrCompany == 'I')
    {
        Console.Write("Health expenditures: ");
        expenditures = double.Parse(Console.ReadLine());

        listaDeContribuintes.Add(new PessoaFisica(expenditures, name, income));
    }
    else
    {
        Console.Write("Number of employees: ");
        nEmployees = int.Parse(Console.ReadLine());

        listaDeContribuintes.Add(new PessoaJuridica(name, income, nEmployees));    
    }    
}

Console.WriteLine("\nTAXES PAID: ");
foreach (Contribuinte contribuinte in listaDeContribuintes)
{
    Console.WriteLine($"{contribuinte.Nome}: $ {contribuinte.ValorImportoPagar().ToString("F2", CultureInfo.InvariantCulture)}");
}

Console.Write($"TOTAL TAXES: $ {Contribuinte.TotalTaxes.ToString("F2", CultureInfo.InvariantCulture)}");