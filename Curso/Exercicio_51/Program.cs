using Exercicio_51.Models;
using System.Globalization;

int nFuncionarios = new int();
int idFuncionario = new int();
double salarioFuncionario = new double();
double porcentagem = new double();
string nomeDuncionario;
bool condicao = new bool();

Console.Write("Informe o número de funcionários: ");
nFuncionarios = int.Parse(Console.ReadLine());

List<Employes> listaEmplyes = new List<Employes>();

for (int i = 0; i < nFuncionarios; i++)
{

    do
    {
        Console.Write($"Informe o ID do {i + 1}º funcionário: ");
        idFuncionario = int.Parse(Console.ReadLine());
        foreach (var item in listaEmplyes)
        {
            if (item.Id == idFuncionario)
            {
                Console.WriteLine("ID já Existe, tente outro.");
                condicao = true;
            }
            else
            {
                condicao = false;
            }
        }
    } while (condicao);

    Console.Write($"Nome: ");
    nomeDuncionario = Console.ReadLine();
    Console.Write("Salário $ ");
    salarioFuncionario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    listaEmplyes.Add(new Employes(idFuncionario, salarioFuncionario, nomeDuncionario));
}

Console.WriteLine("\n");

foreach (var item in listaEmplyes)
{
    Console.WriteLine($"{item.Id} - {item.Nome}, {item.Salario.ToString("F2", CultureInfo.InvariantCulture)}");
}

condicao = true;

do
{
    Console.Write("Informe o ID do funcionário para realizar um aumento: ");
    idFuncionario = int.Parse(Console.ReadLine());

    foreach (var item in listaEmplyes)
    {
        if (item.Id == idFuncionario)
        {
            Console.Write("\nInforme a porcentagem para aumentar o salário: ");
            porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            item.AumentarSalario(porcentagem);
            Console.WriteLine($"{item.Id} - {item.Nome}, {item.Salario.ToString("F2", CultureInfo.InvariantCulture)}");
            condicao = false;
        }
    }

    if (condicao == true)
    {
        Console.WriteLine("ID não localizado, tente novamente.");
    }

} while (condicao);

