using Exercicio_71.Models.Enums;

namespace Exercicio_71.Models
{
    internal class Circulo : Figura
    {
        public double Raio { get; private set; } = new double();

        public Circulo(double raio, Cor cor) : base (cor)
        {
            Raio = raio;
        }

        public override double CalcularArea()
        {
            return Math.PI * (Math.Pow(Raio, 2));
        }
    }
}
