namespace Exercicio_70.Models
{
    internal abstract class Pessoa
    {
        public string Nome { get; protected set; }
        public double RendaAnual { get; protected set; }

        protected Pessoa(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double CalcularImposto();
    }
}
