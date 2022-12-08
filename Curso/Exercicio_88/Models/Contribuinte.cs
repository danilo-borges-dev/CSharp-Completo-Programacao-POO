namespace Exercicio_88.Models
{
    internal abstract class Contribuinte
    {
        public string Nome { get; protected set; }
        public double RendaAnual { get; protected set; } = new double();

        protected Contribuinte(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }
        public abstract double CalcularImposto();
    }
}
