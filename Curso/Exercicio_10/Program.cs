using System.Globalization;
using Exercicio_10;
    
Console.Write("Nome = ");
string nome = Console.ReadLine();
Console.Write("Salário Bruto = ");
double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Imposto = ");
double imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Funcionario f = new(nome, salario);
f.Imposto = imposto;

Console.WriteLine($"\nFuncionário: {f.Nome}, ${f.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}");

Console.Write("\nDigite a porcentagem para aumentar o salário = ");
double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
f.AumentarSalario(porcentagem);

Console.WriteLine($"\nDados atualizados: {f.Nome}, ${f.SalarioBruto.ToString("F2", CultureInfo.InvariantCulture)}");