using Exercicio_99.Entities;
using Exercicio_99.Entities.Enums;
using System.Globalization;

int nShapes = new int();
char rectangleOrCircle = new char();
int color = new int();
Color colorEnum = new Color();
double radius = new double();
double width = new double();
double height = new double();

List<Shape> shapes = new List<Shape>();

Console.Write("Enter the number of shapes: ");
nShapes = int.Parse(Console.ReadLine());

for (int i = 0; i < nShapes; i++)
{
    Console.WriteLine($"\nShape #{i +1 } data:");
    Console.Write("Rectangle or Circle (r/c)? ");
    rectangleOrCircle = char.Parse(Console.ReadLine());
    Console.Write("Color 1 - Black | 2 - Blue | 3 - Red? ");
    color = int.Parse(Console.ReadLine());

    if (color == 1)
    {
        colorEnum = Color.Black;
    }
    else if (color == 2)
    {
        colorEnum = Color.Blue;
    }
    else
    {
        colorEnum = Color.Red;
    }

    if (rectangleOrCircle == 'c' || rectangleOrCircle == 'C')
    {
        Console.Write("Radius: ");
        radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        shapes.Add(new Circle(colorEnum, radius));
    }
    else
    {
        Console.Write("Width: ");
        width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Height: ");
        height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        shapes.Add(new Rectangle(colorEnum, width, height));
    }
}

Console.WriteLine("\nSHAPES AREAS:");
foreach (Shape shape in shapes)
{
    Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
}