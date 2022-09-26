namespace Exercicio_19
{
    internal static class Moeda
    {
        public static double CalcularCotacao(double cotacaoDolar, double qtdDolar)
        {
            return ((cotacaoDolar * qtdDolar) * 0.06) + (cotacaoDolar * qtdDolar);
        }
    }
}
