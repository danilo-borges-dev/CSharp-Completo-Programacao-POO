using Exercicio_79.Models;
using System.Globalization;

int qtdFuncionarios = new int();
int id = new int();
string nomeFuncionario;
double salarioFuncionario = new double();
double porcentagemAumentoSalario = new double();
bool condicao = true;

List<Funcionario> listaDeFuncionarios = new List<Funcionario>();

Console.Write("Quantos funcionários existem na empresa? ");
qtdFuncionarios = int.Parse(Console.ReadLine());

for (int i = 0; i < qtdFuncionarios; i++)
{
    Console.WriteLine($"\nFuncionário #{i + 1}: ");
    Console.Write("ID: ");
    id = int.Parse(Console.ReadLine());
    Console.Write("Nome: ");
    nomeFuncionario = Console.ReadLine();
    Console.Write("Salário $ ");
    salarioFuncionario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    listaDeFuncionarios.Add(new Funcionario(id, nomeFuncionario, salarioFuncionario));
}

Console.Write("\nInforme o ID do Funcionário que terá aumento de Salário: ");
id = int.Parse(Console.ReadLine());

while (condicao)
{
    foreach (Funcionario funcionario in listaDeFuncionarios)
    {
        if (id == funcionario.Id)
        {
            Console.Write("Informe o valor da Porcentagem de Aumento: ");
            porcentagemAumentoSalario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(porcentagemAumentoSalario);
            condicao = false;
        }
    }

    if (condicao = true)
    {
        Console.Write($"\nID {id} de Funcionário não Existe.\nDigite outro: ");
        id = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("\nLista de Funcionários: ");
foreach (Funcionario funcionario in listaDeFuncionarios)
{
    Console.WriteLine($"{funcionario.Id}, {funcionario.Nome}, {funcionario.Salario.ToString("F2", CultureInfo.InvariantCulture)}");
}
