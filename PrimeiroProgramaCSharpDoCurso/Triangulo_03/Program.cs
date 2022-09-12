using Triangulo_03;
using System.Globalization;

Triangulo x = new();
Triangulo y = new();

Console.WriteLine("Entre com as medidas do triângulo X: ");
x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre com as medidas do triângulo Y: ");
y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Área de X = " + x.CalcularArea().ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("Área de Y = " + y.CalcularArea().ToString("F4", CultureInfo.InvariantCulture));