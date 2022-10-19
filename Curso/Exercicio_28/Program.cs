using Exercicio_28;
using System.Globalization;

Funcionario f;
string nome;
double salario = new double();
double imposto = new double();
double porcentagem = new double();

Console.Write("Nome: ");
nome = Console.ReadLine();
Console.Write("Salario Bruto: $ ");
salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Imposto: $ ");
imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

f = new(nome, salario, imposto);

Console.WriteLine($"\nFuncionário: {f.Nome}, {f.CalcularSalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}");

Console.Write("Digite a porcentagem para aumentar o salario: ");
porcentagem = double.Parse(Console.ReadLine());
f.AumentarSalario(porcentagem);

Console.WriteLine(f);
