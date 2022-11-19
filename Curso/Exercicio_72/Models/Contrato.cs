namespace Exercicio_72.Models
{
    internal class Contrato
    {
        public DateTime Data { get; private set; } = new DateTime();
        public double ValorPorHora { get; private set; } = new double();
        public int QuantidadeHoras { get; private set; } = new int();
        public Contrato(DateTime data, double valorPorHora, int quantidadeHoras)
        {
            Data = data;
            ValorPorHora = valorPorHora;
            QuantidadeHoras = quantidadeHoras;
        }
        public double ValorTotal()
        {
            return ValorPorHora * QuantidadeHoras;
        }
    }
}
