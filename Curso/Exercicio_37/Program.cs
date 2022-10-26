using Exercicio_37;
using System.Globalization;

string nome;
double[] notas = new double[3];
Aluno aln;

Console.WriteLine("Digite o nome do aluno: ");
nome = Console.ReadLine();
Console.WriteLine("Digite as três notas do aluno: ");
notas[0] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
notas[1] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
notas[2] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
aln = new(nome, notas);

aln.CalcularNotaFinal();
Console.WriteLine(aln);

