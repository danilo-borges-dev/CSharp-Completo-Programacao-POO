using Exercicio_17;
using System.Globalization;

Console.Write("Nome: ");
string nome = Console.ReadLine();
Console.Write("Salário bruto: ");
double salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Imposto: ");
double imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Funcionario f = new(nome, salarioBruto, imposto);

Console.WriteLine($"Funcionário: {f.Nome}, $ {f.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}");

Console.Write("\nDigite a porcetangem para aumentar o salário: ");
double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

f.AumentarSalario(porcentagem);

Console.WriteLine(f);