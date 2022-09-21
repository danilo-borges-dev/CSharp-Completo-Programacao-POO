using Exercicio_14;
using System.Globalization;

List<Funcionario> funcionarioList = new();

for (int i = 0; i <= 1; i++)
{
    Console.WriteLine($"Dados do {i + 1}º funcionário:");
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Salário: ");
    double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    funcionarioList.Add(new Funcionario(nome, salario));
}

double mediaDeSalario = CalcularMediaDeSalario(funcionarioList);

Console.WriteLine($"Salário Médio ${mediaDeSalario.ToString("F2", CultureInfo.InvariantCulture)}");

double CalcularMediaDeSalario(List<Funcionario> funcionarioList)
{

    double salarioTotal = new double();
    int i = 0;
    foreach (var salario in funcionarioList)
    {
        salarioTotal += funcionarioList[i].Salario;
        i++;
    }
    return salarioTotal / funcionarioList.Count;
}
