using System.Globalization;

Console.WriteLine("\n");

string Produto1 = "Computador";
string Produto2 = "Mesa de Escritório";

byte Idade = 30;
int Codigo = 5290;
char Genero = 'M';

double Preco1 = 2100.0;
double Preco2 = 650.50;
double Medida = 53.234567;

Console.WriteLine("Produtos: ");
Console.WriteLine($"{Produto1}, cujo o preço é ${Preco1:F2}");
Console.WriteLine($"{Produto2}, cujo o preço é ${Preco2:F2}\n\n");

Console.WriteLine($"Registro: {Idade} anos de idade, código {Codigo} e gênero: {Genero}\n\n");


Console.WriteLine($"Medida com oito casa decimais: {Medida:F8}");
Console.WriteLine($"Arredondado (três casa decimais): {Medida:F3}");
Console.WriteLine($"Separador decimal invariant culture: {Medida.ToString("F3", CultureInfo.InvariantCulture)}");

Console.WriteLine("\n");

double value2 = 10_123.56986;

Console.WriteLine($"Três casas decimais {value2.ToString("F3", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Três casas decimais {value2:F3}");


int n7 = new int();
double n8 = new double();
decimal n9 = new decimal();
float n10 = new float();
ulong n11 = new ulong();
long n12 = new long();
short n13 = new short();
byte n14 = new byte();
char n15 = new char();
string n16;
bool n17= new bool();
