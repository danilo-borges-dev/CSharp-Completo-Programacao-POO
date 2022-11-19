using Exercicio_71.Models.Enums;

namespace Exercicio_71.Models
{
    internal class Retangulo : Figura
    {
        public double Largura { get; private set; } = new double();
        public double Altura { get; private set; } = new double();

        public Retangulo(double largura, double altura, Cor cor) : base (cor)
        {
            Largura = largura;
            Altura = altura;
        }

        public sealed override double CalcularArea()
        {
            return Largura * Altura;
        }
    }
}
