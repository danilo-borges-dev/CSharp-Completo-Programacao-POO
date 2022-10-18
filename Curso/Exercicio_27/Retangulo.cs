namespace Exercicio_27
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
            return Altura * Largura;
        }
        public double CalcularPerimetro()
        {
            return 2 * (Altura + Largura);
        }
        public double CalcularDiagonal()
        {
            return Math.Sqrt( Math.Pow(Altura, 2) + Math.Pow(Largura, 2) );
        }
    }
}
