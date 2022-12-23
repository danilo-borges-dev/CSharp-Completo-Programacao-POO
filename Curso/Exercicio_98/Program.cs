using Exercicio_98.Entities;
using System.Globalization;

int qtdTaxPayers = new int();
char indivualOrCompany = new char();
string name;
double anualIncome = new double();
double healthExpenditures = new double();
int qtdEmployess = new int();
double totalImposto = new double();

List<Pessoa> pessoas= new List<Pessoa>();

Console.Write("Enter the number of tax payers: ");
qtdTaxPayers = int.Parse(Console.ReadLine());

for (int i = 0; i < qtdTaxPayers; i++)
{
    Console.WriteLine($"\nTax payer #{1 + i} data:");
    Console.Write("Individual or company (i/c)? ");
    indivualOrCompany = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    name = Console.ReadLine();
    Console.Write("Anual income $ ");
    anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (indivualOrCompany == 'i' || indivualOrCompany == 'I')
    {
        Console.Write("Health expenditures $ ");
        healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        pessoas.Add(new PessoaFisica(name, anualIncome, healthExpenditures));
    }
    else
    {
        Console.Write("Number os employees: ");
        qtdEmployess = int.Parse(Console.ReadLine());

        pessoas.Add(new PessoaJuridica(name, anualIncome, qtdEmployess));
    }

}

Console.WriteLine("\nTAXES PAID:");
foreach (Pessoa pessoa in pessoas)
{
    Console.WriteLine($"{pessoa.Nome}, $ {pessoa.CalcularImposto().ToString("F2", CultureInfo.InvariantCulture)}");
    totalImposto += pessoa.CalcularImposto();
}
Console.WriteLine($"TOTAL TAXES $ {totalImposto.ToString("F2", CultureInfo.InvariantCulture)}");