using Exercicio_67.Models.Enums;

namespace Exercicio_67.Models
{
    internal sealed class Circle : Shape
    {
        public double Radius { get; private set; } = new double();

        public Circle(Color color, double radius) : base (color)
        {
            Radius = radius;
        }

        public sealed override double Area()
        {
            return Math.PI * (Math.Pow(Radius, 2));
        }
    }
}
