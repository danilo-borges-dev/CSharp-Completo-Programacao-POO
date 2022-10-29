
using System.Globalization;

int quantidadeNumeros = new int();
double[] valores;

Console.Write("Informa a quantidade de valores que irá cadastrar no sistema: ");
quantidadeNumeros = int.Parse(Console.ReadLine());
valores = new double[quantidadeNumeros];

for (int i = 0; i < quantidadeNumeros; i++)
{
    Console.Write($"Informe o {i + 1}º valor: $ ");
    valores[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}

Console.WriteLine("\nOs valores digitados foram: ");
for (int i = 0; i < quantidadeNumeros; i++)
{
    Console.WriteLine(valores[i]);
}