using Exercicio_113.Entities.Enums;

namespace Exercicio_113.Entities
{
    internal sealed class Circle : Shape
    {
        public double Radius { get; private set; }
        public Circle(Color color, double radius) : base (color)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
