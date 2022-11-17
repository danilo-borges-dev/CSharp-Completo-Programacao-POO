namespace Exercicio_67.Models
{
    internal sealed class Retangule : Shape
    {
        public double Width { get; private set; } = new double();
        public double Heigth { get; private set; } = new double();

        public Retangule(string color, double width, double heigth) : base (color)
        {
            Width = width;
            Heigth = heigth;
        }

        public override double Area()
        {
            throw new NotImplementedException();
        }
    }
}
