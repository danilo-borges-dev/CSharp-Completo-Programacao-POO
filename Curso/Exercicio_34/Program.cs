using System.Globalization;

string[] nome = new string[2];
double[] salario = new double[2];
double salarioMedio = new double();

for (int i = 0; i < nome.Length; i++)
{
    Console.WriteLine($"Dados do {i + 1}ª funcionário.");
    Console.Write("Nome: ");
    nome[i] = Console.ReadLine();
    Console.Write("Salário: $ ");
    salario[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}


salarioMedio = (salario[0] + salario[1]) / 2.0;

Console.WriteLine($"Salário médio $ {salarioMedio.ToString("F2", CultureInfo.InvariantCulture)}");