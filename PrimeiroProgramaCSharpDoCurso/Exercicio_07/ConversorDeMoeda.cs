namespace Exercicio_07
{

    internal class ConversorDeMoeda
    {
        public static double ConverterMoeda(double cotacao, double quantidade)
        {
            double valorASerpago = new double();
            valorASerpago = (cotacao * quantidade);
            valorASerpago += (cotacao * quantidade) * 0.06;
            //return (cotacao * quantidade) * 0.06;
            return valorASerpago;
        }
    }
}
