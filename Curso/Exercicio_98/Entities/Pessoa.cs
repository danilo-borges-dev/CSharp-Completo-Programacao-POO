namespace Exercicio_98.Entities
{
    internal abstract class Pessoa
    {
        public string Nome { get; private set; }
        public double RendaAnual { get; private set; }
        public Pessoa(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual= rendaAnual;
        }
        public abstract double CalcularImposto();
    }
}
