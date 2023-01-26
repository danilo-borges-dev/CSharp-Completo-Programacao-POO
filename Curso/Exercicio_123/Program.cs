using Exercicio_123.Entities;
using Exercicio_123.Entities.Enums;
using static System.Console;
using System.Globalization;

int nShapes = new int();
short optionShape = new int();
string colorShape = string.Empty;
double width = new double();
double height = new double();
double radius = new double();
EColor eColor = new EColor();

List<Shape> shapes = new List<Shape>();

Write("Enter the number of shapes: ");
nShapes = int.Parse(ReadLine());
for (int i = 0; i < nShapes; i++)
{
    WriteLine($"\nShape #{i + 1} data:");
    Write("Rectangle or Circle (1 - R/ 2 - C)? ");
    optionShape = short.Parse(ReadLine());
    Write("Color (Black,Blue,Red)? ");
    colorShape = ReadLine();
    Enum.TryParse(colorShape, out eColor);

    if (optionShape == 1)
    {
        Write("Width: ");
        width = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
        Write("Height");
        height = double.Parse(ReadLine(), CultureInfo.InvariantCulture);

        shapes.Add(new Rectangle(width, height, eColor));
    }
    else
    {
        Write("Radius: ");
        radius = double.Parse(ReadLine(), CultureInfo.InvariantCulture);

        shapes.Add(new Circle(radius, eColor));
    }
}

WriteLine("\nShape Areas: ");
foreach (var shape in shapes)
{
    WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
}