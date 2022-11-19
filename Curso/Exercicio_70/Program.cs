using Exercicio_70.Models;
using System.Globalization;

int nPagadores = new int();
char tipoPessoa = new char();
double rendimentoAnual = new double();
double gastosComSaude = new double();
int nEmpregados = new int();
double totalArrecadado = new double();
string nome;

List<Pessoa> listaDePessoas = new List<Pessoa>();

Console.Write("Informe o número de pagadores: ");
nPagadores = int.Parse(Console.ReadLine());

for (int i = 0; i < nPagadores; i++)
{
    Console.WriteLine($"\nContribuinte #{i + 1}: ");
    Console.Write("Individual or company (f/j): ");
    tipoPessoa = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    nome = Console.ReadLine();
    Console.Write("Rendimento Anual $ ");
    rendimentoAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (tipoPessoa == 'f' || rendimentoAnual == 'F')
    {
        Console.Write("Gastos com saúde $ ");
        gastosComSaude = double.Parse(Console.ReadLine());

        listaDePessoas.Add(new PessoaFisica(nome, rendimentoAnual, gastosComSaude));
    }
    else
    {
        Console.Write("Número de empregados: ");
        nEmpregados = int.Parse(Console.ReadLine());

        listaDePessoas.Add(new PessoaJuridica(nome, rendimentoAnual, nEmpregados));
    }
}


Console.WriteLine("\nTAXAS PAGAS:");
foreach (Pessoa pessoa in listaDePessoas)
{
    Console.WriteLine($"{pessoa.Nome}, $ {pessoa.CalcularImposto().ToString("F2", CultureInfo.InvariantCulture)}");
    totalArrecadado += pessoa.CalcularImposto();
}

Console.WriteLine($"\nTotal: $ {totalArrecadado.ToString("F2", CultureInfo.InvariantCulture)}");