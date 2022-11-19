using Exercicio_71.Models.Enums;

namespace Exercicio_71.Models
{
    internal abstract class Figura
    {
        public Cor Cor { get; protected set; } = new Cor();

        protected Figura(Cor cor)
        {
            Cor = cor;
        }

        public abstract double CalcularArea();
    }
}
