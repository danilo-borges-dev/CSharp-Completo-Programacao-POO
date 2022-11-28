using Exercicio_81.Models.Enums;

namespace Exercicio_81.Models
{
    internal class Circle : Shape
    {
        public double Radius { get; private set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return Math.PI * (Math.Pow(Radius, 2));
        }
    }
}
