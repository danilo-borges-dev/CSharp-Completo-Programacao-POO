using Exercicio_89.Models.Enums;

namespace Exercicio_89.Models
{
    internal sealed class Circle : Shape
    {
        public double Radius { get; private set; } = new double();
        public Circle(Color color, double radius) : base (color)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return Math.PI * (Math.Pow(Radius, 2));
        }
    }
}
