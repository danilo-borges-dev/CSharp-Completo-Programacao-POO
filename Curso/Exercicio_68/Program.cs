using Exercicio_68.Models;
using System.Globalization;

int nContribuintes = new int();
double rendaAnual = new double();
char tipoPessoa = new char();
double gastosSaude = new double();
int nFuncionarios = new int();
string nome;

List<Pessoa> pessoaLista = new List<Pessoa>();

Console.Write("Informa a quantidade de contribuintes: ");
nContribuintes = int.Parse(Console.ReadLine());

for (int i = 0; i < nContribuintes; i++)
{
    Console.WriteLine($"Dados do #{i + 1} contribuinte: ");
    Console.Write("Nome: ");
    nome = Console.ReadLine();
    Console.Write("Renda anual $ ");
    rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Pessoa Física ou Jurídica (f/r): ");
    tipoPessoa = char.Parse(Console.ReadLine());

    if (tipoPessoa == 'f' || tipoPessoa == 'F')
    {
        Console.Write("Informe os gastos com Saúde $ ");
        gastosSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        pessoaLista.Add(new PessoaFisica(rendaAnual, gastosSaude, nome));
    }
    else
    {
        Console.Write("Informe a quantidade de Funcionários: ");
        nFuncionarios = int.Parse(Console.ReadLine());

        pessoaLista.Add(new PessoaJuridica(nFuncionarios, nome, rendaAnual));
    }
}

