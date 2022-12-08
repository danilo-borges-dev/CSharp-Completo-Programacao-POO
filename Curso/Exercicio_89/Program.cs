using Exercicio_89.Models;
using Exercicio_89.Models.Enums;
using System.Globalization;

int qtdShapes = new int();
char rectangleOrCircle = new char();
int color = new int();
Color enumColor = new Color();
double radius = new double();
double width = new double();
double heidth = new double();

List<Shape> shapeList = new List<Shape>();

Console.Write("Enter the number os shapes: ");
qtdShapes = int.Parse(Console.ReadLine());

for (int i = 0; i < qtdShapes; i++)
{
    Console.WriteLine($"\nShape #{i + 1} data: ");
    Console.Write("Rectangle or circle (r/c)? ");
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

    if (rectangleOrCircle == 'C' || rectangleOrCircle == 'c')
    {
        Console.Write("Radius: ");
        radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        shapeList.Add(new Circle(enumColor, radius));
    }
    else
    {
        Console.Write("Width: ");
        width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Height: ");
        heidth = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        shapeList.Add(new Reactangle(enumColor, width, heidth));
    }
}

Console.WriteLine("\nShape Areas:");
foreach (Shape shape in shapeList)
{
    Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
}
