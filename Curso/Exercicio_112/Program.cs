using Exercicio_112.Entities;
using System.Globalization;

List<Pessoa> listaDePessoas = new List<Pessoa>();

Console.Write("Enter the number of tax payers: ");
int nTaxPayers = int.Parse(Console.ReadLine());

for (int i = 0; i < nTaxPayers; i++)
{
    Console.WriteLine($"\nTax payer #{i + 1} data:");
    Console.Write("Individual or company (i/c)? ");
    char option = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Anual income: ");
    double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    if (option == 'i' || option == 'I')
    {
        Console.Write("Health expenditures: ");
        double expenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        listaDePessoas.Add(new PessoaFisica(name, income, expenditures));
    }
    else
    {
        Console.Write("Numbers of employees: ");
        int nEmployees = int.Parse(Console.ReadLine());
        listaDePessoas.Add(new PessoaJuridica(name, income, nEmployees));
    }
}

Console.WriteLine("\nTAXES PAID:");
double total = new double();
foreach (var pessoa in listaDePessoas)
{
    total += pessoa.CalcularImporto();
    Console.WriteLine($"{pessoa.Nome}, $ {pessoa.CalcularImporto().ToString("F2", CultureInfo.InvariantCulture)}");
}
Console.WriteLine($"\nTOTAL TAXES: $ {total.ToString("F2", CultureInfo.InvariantCulture)}");