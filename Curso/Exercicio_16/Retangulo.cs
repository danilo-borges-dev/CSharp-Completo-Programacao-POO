namespace Exercicio_16
{
    internal class Retangulo
    {
        public double Altura { get; private set; }
        public double Largura { get; private set; }

        public Retangulo(double altura, double largura)
        {
            Altura = altura;
            Largura = largura;
        }

        public double CalcularArea()
        {
            return Largura * Altura;
        }
        public double CalcularPerimetro()
        {
            return 2 * Largura + 2 * Altura;
        } 

        public double CalcularDiagonal()
        {
            return Math.Sqrt(Math.Pow(Largura, 2) + (Math.Pow(Altura, 2)));
        }
    }
}
