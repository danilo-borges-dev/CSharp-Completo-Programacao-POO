namespace Exercicio_106.Entities
{
    internal class ContratoPorHora
    {
        public DateTime Data { get; private set; }
        public double ValorPorHora { get; private set; }
        public int Horas { get; private set; }
        public ContratoPorHora(DateTime data, double valorPorHora, int horas)
        {
            Data = data;
            ValorPorHora = valorPorHora;
            Horas = horas;
        }
        public double ValorTotal()
        {
            return Horas * ValorPorHora;
        }
    }
}
