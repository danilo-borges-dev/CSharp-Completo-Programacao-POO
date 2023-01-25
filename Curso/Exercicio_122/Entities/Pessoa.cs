namespace Exercicio_122.Entities
{
    internal abstract class Pessoa
    {
        public string Nome { get; private set; } = string.Empty;
        public double RendaAnual { get; private set; } = new double();
        protected Pessoa(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }
        public abstract double CalcularImpostos();
    }
}
