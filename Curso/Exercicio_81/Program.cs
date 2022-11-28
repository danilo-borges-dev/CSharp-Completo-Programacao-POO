using Exercicio_81.Models;
using Exercicio_81.Models.Enums;
using System.Globalization;

int nShapes = new int();
char rectangleOrCircle = new char();
double width = new double();
double height = new double();
int color = new int();
Color enumColor = new Color();
double radius = new double();

List<Shape> shapesList = new List<Shape>();

Console.Write("Enter the number os shapes: ");
nShapes = int.Parse(Console.ReadLine());

for (int i = 0; i < nShapes; i++)
{
    Console.WriteLine($"\nShape #{i + 1} data:");
    Console.Write("Rectangle or Circle (r/c) ? ");
    rectangleOrCircle = char.Parse(Console.ReadLine());
    Console.Write("Color (1 - Black | 2 - Blue | 3 - Red): ");
    color = int.Parse(Console.ReadLine());

    if (color == 1)
    {
        Enum.TryParse("Black", out enumColor);
    }
    else if (color == 2)
    {
        Enum.TryParse("Blue", out enumColor);
    }
    else
    {
        Enum.TryParse("Red", out enumColor);
    }

    if (rectangleOrCircle == 'r' || rectangleOrCircle == 'R')
    {
        Console.Write("Width: ");
        width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Height: ");
        height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        shapesList.Add(new Rectangle(width, height, enumColor));
    }
    else
    {
        Console.Write("Radius: ");
        radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        shapesList.Add(new Circle(radius, enumColor));
    }
}

Console.WriteLine("\nSAHPES AREAS: ");
foreach (Shape shape in shapesList)
{
    Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
}