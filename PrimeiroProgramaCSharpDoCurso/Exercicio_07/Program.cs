using Exercicio_07;
using System.Globalization;

double cotacaoDolar = new double();
double quantidadeQueIraComprar = new double();
double valorASerPago = new double();

Console.Write("Qual é a cotação do dólar? ");
cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Quantos dólares você vai comprar? ");
quantidadeQueIraComprar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

valorASerPago = ConversorDeMoeda.ConverterMoeda(cotacaoDolar, quantidadeQueIraComprar);

Console.WriteLine($"Valor a ser pago em reais: {valorASerPago.ToString("F2", CultureInfo.InvariantCulture)}");