
using MetodoDeEstensao;

string mensagem = "Hello World";
string mensagemInvertida = mensagem.Revert();
Console.WriteLine($"Mensagem original: {mensagem}");
Console.WriteLine($"Mensagem invertida: {mensagemInvertida}");

float a = 10f;
double b = a;
decimal c = (decimal)b;
float e = b;

Console.WriteLine(decimal.MaxValue);
Console.WriteLine(decimal.MinValue);