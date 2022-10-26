using Exercicio_36;
using System.Globalization;

string nome;
double salario = new double();
double impostos = new double();
double porcentagem = new double();
Funcionario f;

Console.Write("Nome: ");
nome = Console.ReadLine();
Console.Write("Salario Bruto: $ ");
salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Impostos: $ ");
impostos = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

f = new(nome, salario, impostos);

Console.WriteLine($"\nFuncionário {f.Nome}, Salário $ {f.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}");

Console.Write("\nDigite a Porcentagem para Aumentar o Salário: ");
porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
f.AumentarSalario(porcentagem);

Console.WriteLine(f);

