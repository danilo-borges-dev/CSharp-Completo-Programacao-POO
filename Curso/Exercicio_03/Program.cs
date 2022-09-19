using Exercicio_03;
using System.Globalization;

Retangulo r = new();

Console.WriteLine("Entre com a largura e altura do retângulo:");
r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine($"\n{r}");


