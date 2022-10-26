using Exercicio_35;
using System.Globalization;

double largura = new double();
double altura = new double();
Retangulo r;

Console.WriteLine("Entre com a Largura e a Altura do Retângulo: ");
largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

r = new(largura, altura);

Console.WriteLine($"\nÁrea: {r.Area()}");
Console.WriteLine($"Perímetro: {r.Perimetro()}");
Console.WriteLine($"Diagonal: {r.Diagonal()}");

