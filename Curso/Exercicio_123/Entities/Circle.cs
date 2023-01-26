using Exercicio_123.Entities.Enums;

namespace Exercicio_123.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; private set; } = new double();
        public Circle(double radius, EColor color) : base (color)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }
    }
}
