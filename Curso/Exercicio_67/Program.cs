using Exercicio_67.Models;
using Exercicio_67.Models.Enums;
using System.Globalization;

int nShapes = new int();
char option = new char();
double width = new double();
double height = new double();
double radius = new double();
string color;
Color colorEnum = new Color();

List<Shape> shapeList = new List<Shape>();

Console.Write("Enter the number os shapes? ");
nShapes = int.Parse(Console.ReadLine());

for (int i = 0; i < nShapes; i++)
{
    Console.WriteLine($"\nShape #{i + 1} data: ");
    Console.Write("Rectangle or Circle (r/c)? ");
    option = char.Parse(Console.ReadLine());
    Console.Write("Color (Black/Blue/Red): ");
    color = Console.ReadLine();

    Enum.TryParse(color, out colorEnum);

    if (option == 'r' || option == 'R')
    {
        Console.Write("Width: ");
        width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Height: ");
        height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        shapeList.Add(new Retangule(colorEnum, width, height));
    }
    else
    {
        Console.Write("Radius: ");
        radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        shapeList.Add(new Circle(colorEnum, radius));
    }
}

Console.WriteLine("\nSHAPE AREAS: ");
foreach (Shape shape in shapeList)
{
    Console.WriteLine($"{shape.Area().ToString("F2", CultureInfo.InvariantCulture)}");
}