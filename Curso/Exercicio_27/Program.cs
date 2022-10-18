using Exercicio_27;
using System.Globalization;

double largura = new double();
double altura = new double();
Retangulo r;

Console.WriteLine("Entre com a largura e altura do retâmgulo: ");
largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
r = new(largura, altura);
Console.WriteLine($"AREA = {r.CalcularArea().ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"PERÍMETRO = {r.CalcularPerimetro().ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"DIAGONAL = {r.CalcularDiagonal().ToString("F2", CultureInfo.InvariantCulture)}");
