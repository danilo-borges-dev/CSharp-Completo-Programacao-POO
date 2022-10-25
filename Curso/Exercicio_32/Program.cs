using System.Globalization;

string nomeCompleto;
int qtdQuartos = new int();
double precoProduto = new double();
string[] informacoes = new string[3];

Console.WriteLine("Entre com o seu nome Completo");
nomeCompleto = Console.ReadLine();
Console.WriteLine("Quantos quartos tem na sua casa?");
qtdQuartos = int.Parse(Console.ReadLine());
Console.WriteLine("Entre com o Preço de um produto:");
precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Entre com o seu último nome, idade e altura: (Mesma linha)");
informacoes = Console.ReadLine().Split(" ");


Console.WriteLine($"\n{nomeCompleto}");
Console.WriteLine(qtdQuartos);
Console.WriteLine(precoProduto);
Console.WriteLine(informacoes[0]);
Console.WriteLine(informacoes[1]);
Console.WriteLine(informacoes[2]);

