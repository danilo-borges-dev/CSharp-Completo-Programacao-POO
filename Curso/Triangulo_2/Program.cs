using Triangulo_2;
using System.Globalization;

Triangulo trianguloX = new();
Triangulo trianguloY = new();

Console.WriteLine("Entre com as medidas do triângulo X: ");
trianguloX.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
trianguloX.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
trianguloX.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre com as medidas do triângulo Y: ");
trianguloY.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
trianguloY.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
trianguloY.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double p = (trianguloX.A + trianguloX.B + trianguloX.C) / 2.0;
double areaX = Math.Sqrt(p * (p - trianguloX.A) * (p - trianguloX.B) * (p - trianguloX.C));

p = (trianguloY.A + trianguloY.B + trianguloY.C) / 2.0;
double areaY = Math.Sqrt(p * (p - trianguloY.A) * (p - trianguloY.B) * (p - trianguloY.C));

Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

if (areaX > areaY)
{
    Console.WriteLine("Maior área X");
}
else if (areaX < areaY)
{
    Console.WriteLine("Maior área Y");
}
else
{
    Console.WriteLine("Área de X e Y são iguais.");
}
