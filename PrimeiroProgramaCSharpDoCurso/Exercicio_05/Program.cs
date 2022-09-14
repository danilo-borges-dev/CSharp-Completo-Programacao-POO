using Exercicio_05;
using System.Globalization;

Aluno al = new();

Console.Write("Nome do aluno: ");
al.Nome = Console.ReadLine();

Console.WriteLine("Digite as três notas do aluno: ");
al.Notas[0] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
al.Notas[1] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
al.Notas[2] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

al.CalcularNotaFinal();
