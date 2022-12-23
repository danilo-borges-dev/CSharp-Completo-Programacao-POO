using Exercicio_99.Entities.Enums;

namespace Exercicio_99.Entities
{
    internal abstract class Shape
    {
        public Color Color { get; private set; }
        protected Shape(Color color)
        {
            Color = color;
        }
        public abstract double Area();
    }
}
