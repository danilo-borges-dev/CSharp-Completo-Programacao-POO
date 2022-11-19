using Exercicio_71.Models;
using Exercicio_71.Models.Enums;
using System.Globalization;

int nFiguras = new int();
char opcao = new char();
double largura = new double();
double altura = new double();
double raio = new double();
string cor;
Cor enumCor = new Cor();

List<Figura> figuras = new List<Figura>();

Console.Write("Informe o número de figuras: ");
nFiguras = int.Parse(Console.ReadLine());

for (int i = 0; i < nFiguras; i++)
{
    Console.WriteLine($"\nDados da Figura #{i + 1}: ");
    Console.Write("Retângulo ou Círculo (r/c)? ");
    opcao = char.Parse(Console.ReadLine());
    Console.Write("Cor ( Vermelho | Azul | Preto ): ");
    cor = Console.ReadLine();

    Enum.TryParse(cor, out enumCor);

    if (opcao == 'r' || opcao == 'R')
    {
        Console.Write("Largura: ");
        largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Altura: ");
        altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        figuras.Add(new Retangulo(largura, altura, enumCor));
    }
    else
    {
        Console.Write("Informe o valor do Raio: ");
        raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        figuras.Add(new Circulo(raio, enumCor));
    }
}

Console.WriteLine("\nÁreas Figuras: ");
foreach (Figura figura in figuras)
{
    Console.WriteLine(figura.CalcularArea().ToString("F2", CultureInfo.InvariantCulture));
}