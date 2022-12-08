using Exercicio_89.Models.Enums;

namespace Exercicio_89.Models
{
    internal sealed class Reactangle : Shape
    {
        public double Width { get; private set; } = new double();
        public double Height { get; private set; } = new double();
        public Reactangle(Color color, double width, double height) : base(color)
        {
            Width = width;
            Height = height;
        }
        public override double Area()
        {
            return Width * Height;
        }
    }
}
