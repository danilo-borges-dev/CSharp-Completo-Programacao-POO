using Exercicio_16;
using System.Globalization;

Console.WriteLine("Entre com a Largura e Altura de um Retângulo:");
double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Retangulo r = new(altura, largura);

Console.Write($"\nÁrea = {r.CalcularArea().ToString("F2", CultureInfo.InvariantCulture)}");
Console.Write($"\nPerímetro = {r.CalcularPerimetro().ToString("F2", CultureInfo.InvariantCulture)}");
Console.Write($"\nDiagonal = {r.CalcularDiagonal().ToString("F2", CultureInfo.InvariantCulture)}");
