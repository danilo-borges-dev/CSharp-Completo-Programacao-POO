using System.Globalization;

string nome;
string[] sTexto;
int nQuatros = new int();
double pPreco = new double();

Console.WriteLine("Entre com o seu nome completo: ");
nome = Console.ReadLine();
Console.WriteLine("Quantos quartos tem na sua casa?");
nQuatros = int.Parse(Console.ReadLine());
Console.WriteLine("Entre com o preço de um produto: ");
pPreco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
sTexto = Console.ReadLine().Split(" ");

Console.WriteLine($"\n{nome}");
Console.WriteLine($"{nQuatros}");
Console.WriteLine($"{pPreco.ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"{sTexto[0]}");
Console.WriteLine($"{sTexto[1]}");
Console.WriteLine($"{sTexto[2]}");
