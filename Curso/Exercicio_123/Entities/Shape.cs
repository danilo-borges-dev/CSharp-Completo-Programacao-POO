using Exercicio_123.Entities.Enums;

namespace Exercicio_123.Entities
{
    internal abstract class Shape
    {
        public EColor Color { get; set; } = new EColor();
        protected Shape(EColor color)
        {
            Color = color;
        }
        public abstract double Area();
    }
}
