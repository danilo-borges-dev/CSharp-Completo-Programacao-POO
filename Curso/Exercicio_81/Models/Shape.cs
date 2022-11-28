using Exercicio_81.Models.Enums;

namespace Exercicio_81.Models
{
    internal abstract class Shape
    {
        public Color Color { get; protected set; }
        protected Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
