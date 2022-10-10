using System.Globalization;

string nameComplete;
int roomsTotal = new int();
double productPrice = new double();
string[] s = new string[3];

Console.WriteLine("Informe o seu nome completo: ");
nameComplete = Console.ReadLine();
Console.WriteLine("Quantos quartos tem na sua casa? ");
roomsTotal = int.Parse(Console.ReadLine());
Console.WriteLine("Entre com o preço de um produto: ");
productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Entre com o seu último nome, idade e altura: (Mesma linha)");
s = Console.ReadLine().Split(" ");

Console.WriteLine($"\n{nameComplete}");
Console.WriteLine(roomsTotal);
Console.WriteLine(productPrice.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(s[0]);
Console.WriteLine(s[1]);
Console.WriteLine(s[2]);