using static System.Console;
using System.Globalization;
using Exercicio_122.Entities;

int nPagadores = new int();
short op = new short();
string nome = string.Empty;
double rendaAnual = new double();
double gastosComSaude = new double();
int qtdEmpregados = new int();
double totalDeTaxas = new double();

List<Pessoa> listaPessoas = new List<Pessoa>();

Write("Entre com o número de pagadores: ");
nPagadores = int.Parse(ReadLine());
for (int i = 0; i < nPagadores; i++)
{
    WriteLine($"\nPagador #{i + 1} dados:");
    Write("1 - Pessoa Física ou 2 - Pessoa Jurídica? ");
    op = short.Parse(ReadLine());
    Write("Nome: ");
    nome = ReadLine();
    Write("Renda Anual $ ");
    rendaAnual = double.Parse(ReadLine(), CultureInfo.InvariantCulture);

    if (op == 1)
    {
        Write("Gastos com saúde $ ");
        gastosComSaude = double.Parse(ReadLine(), CultureInfo.InvariantCulture);

        listaPessoas.Add(new PessoaFisica(nome, rendaAnual, gastosComSaude));
    }
    else
    {
        Write("Números de empregados? ");
        qtdEmpregados = int.Parse(ReadLine());

        listaPessoas.Add(new PessoaJuridica(nome, rendaAnual, qtdEmpregados));
    }
}

WriteLine("\nTaxas");
foreach (Pessoa pessoa in listaPessoas)
{
    totalDeTaxas += pessoa.CalcularImpostos();
    WriteLine($"{pessoa.Nome}: $ {pessoa.CalcularImpostos().ToString("F2", CultureInfo.InvariantCulture)}");
}
WriteLine($"Total de Taxas: $ {totalDeTaxas.ToString("F2", CultureInfo.InvariantCulture)} ");