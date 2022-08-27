using System.Globalization;

//string[] s = Console.ReadLine().Split(" ");

//string a = s[0];
//string b = s[1];
//string c = s[2];

//Console.WriteLine(a);
//Console.WriteLine(b);
//Console.WriteLine(c);

Console.WriteLine($"Digite um valor: ");
double n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine(n.ToString("F2", CultureInfo.InvariantCulture));