namespace Exercicio_38
{
    internal static class ConversorDeMoeda
    {
        public static double Converter(double valorDolar, double quantidade)
        {
            return (valorDolar * quantidade) + (valorDolar * quantidade) * 0.06;
        }
    }
}
