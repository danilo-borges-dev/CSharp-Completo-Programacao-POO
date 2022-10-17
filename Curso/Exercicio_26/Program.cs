using System.Globalization;

string[] nomes = new string[2];
double[] salarios = new double[2];

for (int i = 0; i < 2; i++)
{
    Console.WriteLine($"Dados do {i + 1}ª funcionário: ");
    Console.Write("Nome: ");
    nomes[i] = Console.ReadLine();
    Console.Write("Salário $ ");
    salarios[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}

Console.WriteLine($"Salário médio $ {((salarios[0] + salarios[1]) / 2).ToString("F2", CultureInfo.InvariantCulture)}");