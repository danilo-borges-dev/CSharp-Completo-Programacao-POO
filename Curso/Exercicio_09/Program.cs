using Exercicio_09;
using System.Globalization;


Console.WriteLine("Entre com a Largura e Altura do Retângulo:");
double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Retangulo r = new() { Largura = largura, Altura = altura };

Console.WriteLine($"\nArea = {r.CalcularArea().ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Perímetro = {r.CalcularPerimetro().ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Diagonal = {r.CalcularDiagonal().ToString("F2", CultureInfo.InvariantCulture)}");