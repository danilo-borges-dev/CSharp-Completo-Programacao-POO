namespace Exercicio_67.Models
{
    internal abstract class Shape
    {
        public string Color { get; protected set; }

        public Shape(string color)
        {
            Color = color;
        }
        public abstract double Area();
    }
}
