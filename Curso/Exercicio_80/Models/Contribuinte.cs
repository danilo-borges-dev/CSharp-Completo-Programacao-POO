namespace Exercicio_80.Models
{
    internal abstract class Contribuinte
    {
        public string Nome { get; private set; }
        public double RendaAnual { get; protected set; } = new double();

        public static double TotalTaxes { get; protected set; }

        protected Contribuinte(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }
        public abstract double ValorImportoPagar();
    }
}
