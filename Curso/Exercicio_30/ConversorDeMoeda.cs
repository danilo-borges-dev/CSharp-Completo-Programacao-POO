namespace Exercicio_30
{
    internal class ConversorDeMoeda
    {
        public double RealizarConversao(double cotacaoDolar, double totalDolares)
        {
            return cotacaoDolar * totalDolares + (cotacaoDolar * totalDolares * 0.06);
        }
    }
}
