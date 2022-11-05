using System.Collections.Generic;
using System.Globalization;
using Exercicio_45;

int nFuncionarios = new int();
int idFuncionario = new int();
double salario = new double();
double porcentagem = new double();
bool condicao = true;
string nomeFuncionario;

List<Funcionario> listaDeFuncionarios = new List<Funcionario>();

Console.Write("Informe o Número de Funcionários: ");
nFuncionarios = int.Parse(Console.ReadLine());

for (int i = 0; i < nFuncionarios; i++)
{
    do
    {
        Console.Write($"\nInforme o ID do {i + 1}º Funcionário: ");
        idFuncionario = int.Parse(Console.ReadLine());

        foreach (var item in listaDeFuncionarios)
        {
            if (item.Id == idFuncionario)
            {
                Console.WriteLine($"Já Existe Funcionário com Está ID {item.Id}. Tente outra ID.");
                condicao = true;
            }
            else
            {
                condicao = false;
            }
        }

        if (listaDeFuncionarios.Count() == 0)
        {
            condicao = false;
        }

    } while (condicao);
    Console.Write("Nome: ");
    nomeFuncionario = Console.ReadLine();
    Console.Write("Salário $ ");
    salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    listaDeFuncionarios.Add(new Funcionario(idFuncionario, nomeFuncionario, salario));
}

Console.WriteLine("\n");

foreach (var item in listaDeFuncionarios)
{
    Console.WriteLine($"ID {item.Id}# Nome: {item.Nome}, Salário $ {item.Salario.ToString("F2", CultureInfo.InvariantCulture)}");
}

do
{
    condicao = true;
    Console.Write("\nInforme o ID de um Funcionário para Aumentar o Salário: ");
    idFuncionario = int.Parse(Console.ReadLine());

    foreach (var item in listaDeFuncionarios)
    {
        if (item.Id == idFuncionario)
        {
            Console.Write("Informe a porcentagem para Aumentar o Salário: ");
            porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            item.AumentarSalario(porcentagem);
            condicao = false;
        }
    }

    if (condicao == true)
    {
        Console.Write($"ID {idFuncionario} não Localizado, tente novamente!");
    }
    else
    {
        Console.WriteLine("Aumento de Salário Realizado com Sucesso.");

        foreach (Funcionario item in listaDeFuncionarios)
        {
            if (item.Id == idFuncionario)
            {
                Console.WriteLine($"ID {item.Id}# Nome: {item.Nome}, Salário $ {item.Salario.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }

} while (condicao);

Console.WriteLine("\nFim do Programa.");