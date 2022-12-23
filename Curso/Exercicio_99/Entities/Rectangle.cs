﻿using Exercicio_99.Entities.Enums;

namespace Exercicio_99.Entities
{
    internal sealed class Rectangle : Shape
    {
        public double Width { get; private set; }
        public double Height { get; private set; }

        public Rectangle(Color color, double width, double height) : base (color) 
        {
            Width = width;
            Height = height;
        }
        public override double Area()
        {
            return Width * Height;
        }
    }
}
