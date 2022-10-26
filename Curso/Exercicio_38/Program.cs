using Exercicio_38;
using System.Globalization;

double valorDolar = new double();
double qtdDolares = new double();

Console.Write("Valor do Dolar: $ ");
valorDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantos Dolares irá Comprar? ");
qtdDolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine($"\nValor a pagar pelos Dolares: $ {(ConversorDeMoeda.Converter(valorDolar, qtdDolares)).ToString("F2", CultureInfo.InvariantCulture)}");
