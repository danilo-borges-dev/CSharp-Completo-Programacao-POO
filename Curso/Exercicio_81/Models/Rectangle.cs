using Exercicio_81.Models.Enums;

namespace Exercicio_81.Models
{
    internal sealed class Rectangle : Shape
    {
        public double Width { get; private set; } = new double();
        public double Height { get; private set; } = new double();

        public Rectangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
        }

        public sealed override double Area()
        {
            return Width * Height;
        }
    }
}
