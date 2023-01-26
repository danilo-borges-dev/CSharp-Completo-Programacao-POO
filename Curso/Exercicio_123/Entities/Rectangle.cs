using Exercicio_123.Entities.Enums;

namespace Exercicio_123.Entities
{
    internal sealed class Rectangle : Shape
    {
        public double Width { get; private set; } = new double();
        public double Height { get; private set; } = new double();

        public Rectangle(double width, double height, EColor color) : base (color)
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
