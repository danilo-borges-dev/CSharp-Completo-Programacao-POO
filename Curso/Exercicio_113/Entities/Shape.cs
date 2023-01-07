using Exercicio_113.Entities.Enums;

namespace Exercicio_113.Entities
{
    internal abstract class Shape
    {
        public Color Color { get; private set; }
        public Shape (Color color)
        {
            Color = color;
        }
        public abstract double Area();
    }
}
