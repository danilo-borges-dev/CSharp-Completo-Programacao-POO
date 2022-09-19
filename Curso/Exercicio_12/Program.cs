using System.Globalization;

Main();

void Main()
{
    Console.Write("Qual é a cotação do dólar? ");
    double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Quantos dólares você vai comprar? ");
    double qtdDolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    double valorAPagarEmReais = ConversorDeMoeda.CalcularCotacao(cotacao, qtdDolares);

    Console.WriteLine($"Valor a ser pago em reais = {valorAPagarEmReais.ToString("F2", CultureInfo.InvariantCulture)}");

}

public static class ConversorDeMoeda
{
    public static double CalcularCotacao(double cotacao, double quantidade)
    {
        double valorAPagarEmReais = cotacao * quantidade; 
        valorAPagarEmReais += valorAPagarEmReais * 0.06;
        return valorAPagarEmReais;
    }
}
