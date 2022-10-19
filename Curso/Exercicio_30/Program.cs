using Exercicio_30;
using System.Globalization;

ConversorDeMoeda conversor;
double cotacaoDolar = new double();
double totalDolares = new double();

Console.Write("Qual é a cotação do dolar? ");
cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantos dolares você vai comprar? ");
totalDolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

conversor = new();

Console.Write($"Valor a ser pago em reais = $ {conversor.RealizarConversao(cotacaoDolar, totalDolares).ToString("F2", CultureInfo.InvariantCulture)}");
