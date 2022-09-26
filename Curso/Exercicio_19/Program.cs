using Exercicio_19;
using System.Globalization;

Console.Write("Qual é a cotação do dolar? ");
double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantos dolares você vai comprar? ");
double qtdDolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write($"Valor a ser pago em reais: {Moeda.CalcularCotacao(cotacao, qtdDolares).ToString("F2", CultureInfo.InvariantCulture)}");
