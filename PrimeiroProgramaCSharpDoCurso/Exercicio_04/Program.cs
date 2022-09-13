using Exercicio_04;
using System.Globalization;

Funcionario f = new();

Console.Write("Nome: ");
f.Nome = Console.ReadLine();

Console.Write("Salário bruto: ");
f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Imposto: ");
f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
f.DescontarImposto();

Console.WriteLine($"\nFuncíonário {f.Nome}, ${f.SalarioLiquido.ToString("F2", CultureInfo.InvariantCulture)}");

Console.Write($"\nDigite a porcentagem para aumentar o salário: ");
double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
f.AumentarSalario(porcentagem);


Console.WriteLine($"\n{f}");