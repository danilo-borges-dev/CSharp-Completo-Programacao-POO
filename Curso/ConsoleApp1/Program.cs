using System.Globalization;

Console.WriteLine("Entre com o seu nome completo");
string nome = Console.ReadLine();

Console.WriteLine("Quantos quartos tem na sua casa?");
int nQuartos = int.Parse(Console.ReadLine());

Console.WriteLine("Entre com o preço de um produto:");
double precoProd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre com o seu último nome, idade e altura (mesma linha):");
string[] s = Console.ReadLine().Split(" ");

Console.WriteLine(nome);
Console.WriteLine(nQuartos.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(precoProd);
Console.WriteLine(s[0]);
Console.WriteLine(s[1]);
Console.WriteLine(s[2]);

{
    int a = new int();
    Console.WriteLine(a);
}


double d = new double();

