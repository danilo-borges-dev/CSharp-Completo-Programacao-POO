using System.Globalization;

Funcionario f1 = new();
Funcionario f2 = new();

Console.WriteLine("Dados do primeiro funcionário: ");
Console.Write("Nome: ");
f1.Nome = Console.ReadLine();
Console.Write("Salário: ");
f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Dados do segundo funcionário: ");
Console.Write("Nome: ");
f2.Nome = Console.ReadLine();
Console.Write("Salário: ");
f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

f1.CalcularMediaDeSalario(f1.Salario, f2.Salario);
class Funcionario
{
    public string Nome { get; set; }
    public double Salario { get; set; }

    public void CalcularMediaDeSalario(double s1, double s2)
    {
        Console.WriteLine($"Saário médio = {((s1 + s2) / 2).ToString("F2", CultureInfo.InvariantCulture)}");
    }
}
