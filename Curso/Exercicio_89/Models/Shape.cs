using Exercicio_89.Models.Enums;

namespace Exercicio_89.Models
{
    internal abstract class Shape
    {
        public Color Color { get; protected set; }
        public Shape(Color color)
        {
            Color = color;
        }
        public abstract double Area();
    }
}
