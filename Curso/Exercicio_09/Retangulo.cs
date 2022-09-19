namespace Exercicio_09
{
    internal class Retangulo
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

        public Retangulo() { }

        public double CalcularArea()
        {
            return Altura * Largura;
        }

        public double CalcularPerimetro()
        {
            return 2 * (Largura + Altura);
        }

        public double CalcularDiagonal()
        {
            return Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2));
        }
    }
}
