using System.Globalization;

string nomeCompleto;
int qtdQuartos = new int();
double produtoPreco = new double();
string[] informacoes = new string[3];

Console.WriteLine("Entre com o nome completo: ");
nomeCompleto = Console.ReadLine();
Console.WriteLine("Quantos quartos tem na sua casa? ");
qtdQuartos = int.Parse(Console.ReadLine());
Console.WriteLine("Entre com o preço de um produto: ");
produtoPreco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Entre com o seu último nome, idade e altura (mesma linha): ");
informacoes = Console.ReadLine().Split(" ");

Console.WriteLine();

Console.WriteLine(nomeCompleto);
Console.WriteLine(qtdQuartos);
Console.WriteLine(produtoPreco);
Console.WriteLine(informacoes[0]);
Console.WriteLine(informacoes[1]);
Console.WriteLine(informacoes[2]);