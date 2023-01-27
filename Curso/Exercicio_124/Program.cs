using Exercicio_124.Models;
using static System.Console;
using System.Globalization;

int qtdFuncionarios = new int();
int id = new int();
string nome = string.Empty;
double salario = new double();
bool condicao = new bool();
double percentualAumento = new double();

List<Funcionario> listaFuncionarios = new List<Funcionario>();

Write("Quantos funcionários? ");
qtdFuncionarios = int.Parse(ReadLine());

for (int i = 0; i < qtdFuncionarios; i++)
{
    WriteLine($"\nFuncionário #{i + 1}");
    Write("ID: ");
    id = int.Parse(ReadLine());
    Write("Nome: ");
    nome = ReadLine();
    Write("Salary $ ");
    salario = double.Parse(ReadLine(), CultureInfo.InvariantCulture);

    listaFuncionarios.Add(new Funcionario(id, nome, salario));
}

condicao = true;

do
{
    Write("\nInforme o ID do Funcionário para ajuste de salário: ");
    id = int.Parse(ReadLine());

    foreach (var funcionario in listaFuncionarios)
    {
        if (id == funcionario.Id)
        {
            Write("Informe o Percentual de aumento: ");
            percentualAumento = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(percentualAumento);
            condicao = false;
        }
    }

    if (condicao == true)
    {
        WriteLine("ID de funcionário não localizado - Tente novamente:");
    }
    else
    {
        WriteLine("Aumento realizado com sucesso!");
        WriteLine("Funcionários atualizados: ");
        foreach (var funcionario in listaFuncionarios)
        {
            WriteLine($"ID {funcionario.Id} - {funcionario.Nome}, $ {funcionario.Salario.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }

} while (condicao);

WriteLine("Fim do programa");


