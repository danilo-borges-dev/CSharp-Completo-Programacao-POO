using Exercicio_18;
using System.Globalization;

double[] notas = new double[3];

Console.Write("Nome do aluno: ");
string nome = Console.ReadLine();
Console.WriteLine("Digite as três notas do aluno:");
notas[0] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
notas[1] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
notas[2] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Aluno a = new(nome, notas);

a.VerificarAprovacao();
