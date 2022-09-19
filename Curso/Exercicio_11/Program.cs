using Exercicio_11;
using System.Globalization;

Console.Write("Nome do Aluno: ");
string nome = Console.ReadLine();
Console.WriteLine("Digite as três notas do aluno: ");
double[] notas = new double[3];
notas[0] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
notas[1] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
notas[2] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Aluno n = new(nome, notas);

Console.WriteLine(n.CalcularNota());
