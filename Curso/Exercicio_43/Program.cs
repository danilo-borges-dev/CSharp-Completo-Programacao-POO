using Exercicio_43;
using System.Globalization;

int idFuncionario = new int();
string nomeFuncionario;
double salarioFuncionario = new double();
double porcentagemDeAumento = new double();
char opcao = new char();

List<Funcionario> listaDeFuncionarios = new List<Funcionario>();

do
{
    Console.Write("Informe o ID do Funcionário: ");
    idFuncionario = int.Parse(Console.ReadLine());
    Console.Write("Informe o nome Nome do Funcionário: ");
    nomeFuncionario = Console.ReadLine();
    Console.Write("Informe o Salário $ ");
    salarioFuncionario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    listaDeFuncionarios.Add(new Funcionario(idFuncionario, nomeFuncionario, salarioFuncionario));

    Console.Write("\nDeseja cadastrar um Novo Funcionário? (s/n)");
    opcao = char.Parse(Console.ReadLine());

} while (opcao == 'S' || opcao == 's');

Console.WriteLine("\nListagem de Funcionários: ");

foreach (var item in listaDeFuncionarios)
{
    Console.WriteLine($"ID {item.Id} : Nome {item.Nome}, Salário $ {item.Salario.ToString("F2", CultureInfo.InvariantCulture)}");
}

do
{
    Console.WriteLine("\nAplicar Aumento no Salário do Funcionário: ");
    Console.Write("Informe o ID do Funcionário para Aplicar o Aumento: ");
    idFuncionario = int.Parse(Console.ReadLine());

    foreach (var item in listaDeFuncionarios)
    {
        if (item.Id == idFuncionario)
        {
            opcao = 'n';
        }
        else
        {
            Console.WriteLine("ID de Funcionário não localizado. Tente novamente.");
        }
    }

} while (opcao == 's');

Console.Write("Informe a Porcentagem do Aumento: ");
porcentagemDeAumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


foreach (var item in listaDeFuncionarios)
{
    if (item.Id == idFuncionario)
    {
        item.AumentarSalario(porcentagemDeAumento);
    }
}

Console.WriteLine($"\nAumento de Salário Aplicado com Sucesso");
foreach (var item in listaDeFuncionarios)
{
    if (item.Id == idFuncionario)
    {
        Console.WriteLine($"ID {item.Id} : Nome {item.Nome}, Salário $ {item.Salario.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}