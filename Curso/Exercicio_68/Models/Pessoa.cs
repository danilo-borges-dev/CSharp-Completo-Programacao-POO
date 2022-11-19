namespace Exercicio_68.Models
{
    internal abstract class Pessoa
    {
        public string Nome { get; protected set; }
        public double RendaAnual { get; protected set; } = new double();

        protected Pessoa(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double CalcularImposto();
    }
}
