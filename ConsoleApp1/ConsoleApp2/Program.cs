using System.Globalization;

Console.WriteLine("Entre com o seu nome completo: ");
string nomeCompleto = Console.ReadLine();
Console.WriteLine("Quantos quartos tem na sua casa?");
int nQuartos = int.Parse(Console.ReadLine());
Console.WriteLine("Entre com o preço de um produto: ");
double produtoPreco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Entre seu último nome, idade e altura (mesma linha): ");
string[] s = Console.ReadLine().Split(" ");

Console.WriteLine("\n");

Console.WriteLine(nomeCompleto);
Console.WriteLine(nQuartos);
Console.WriteLine(produtoPreco.ToString("F2", CultureInfo.InvariantCulture));

Console.WriteLine(s[0]);
Console.WriteLine(s[1]);
Console.WriteLine(s[2]);

