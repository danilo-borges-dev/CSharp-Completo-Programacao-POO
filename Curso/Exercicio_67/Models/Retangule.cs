using Exercicio_67.Models.Enums;

namespace Exercicio_67.Models
{
    internal sealed class Retangule : Shape
    {
        public double Width { get; private set; } = new double();
        public double Heigth { get; private set; } = new double();

        public Retangule(Color color, double width, double heigth) : base (color)
        {
            Width = width;
            Heigth = heigth;
        }

        public sealed override double Area()
        {
            return Width * Heigth;
        }
    }
}
