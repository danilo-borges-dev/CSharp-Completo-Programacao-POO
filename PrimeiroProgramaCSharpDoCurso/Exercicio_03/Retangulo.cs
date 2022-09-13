using System.Globalization; // Injeção de Dependência de outro Namespace

namespace Exercicio_03
{
    internal class Retangulo
    {
        public double Largura { get; set; }
        public double Altura { get; set; }
        public double Area { get; set; }
        public double Perimetro { get; set; }
        public double Diagonal { get; set; }

        public void CalcularArea()
        {
            Area = Largura * Altura;
        }

        public void CalcularPerimetro()
        {
            Perimetro = 2 * (Largura + Altura);
        }

        public void CalcularDiagonal()
        {
            Diagonal = Math.Pow(Largura, 2) + Math.Pow(Altura, 2);
            Diagonal = Math.Sqrt(Diagonal);
        }

        public override string ToString()
        {
            CalcularArea();
            CalcularPerimetro();
            CalcularDiagonal();

            return $"AREA = {Area.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"PERÍMETRO = {Perimetro.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"DIAGONAL = {Diagonal.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
