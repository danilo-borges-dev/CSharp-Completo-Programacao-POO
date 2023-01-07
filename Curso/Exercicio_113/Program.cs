using Exercicio_113.Entities;
using Exercicio_113.Entities.Enums;
using System.Globalization;

List<Shape> listaShapes = new List<Shape>();

Console.Write("Enter the number of shapes: ");
int nShapes = int.Parse(Console.ReadLine());
for (int i = 0; i < nShapes; i++)
{
    Console.WriteLine($"\nShape #{i + 1} data:");
    Console.Write("Rectangle or Circle (r/c)? ");
    char option = char.Parse(Console.ReadLine());
    Console.Write("Color (Black/Red/Blue)? ");
    string color = Console.ReadLine();
    Color colorEnum = new Color();
    Enum.TryParse(color, out colorEnum);

    if (option == 'r' || option == 'R')
    {
        Console.Write("Width: ");
        double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Heigth: ");
        double heigth = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);

        listaShapes.Add(new Rectangle(colorEnum, width, heigth));
    }
    else
    {
        Console.Write("Radius: ");
        double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        listaShapes.Add(new Circle(colorEnum, radius));
    }
}

Console.WriteLine("\nSHAPES AREAS: ");
foreach (var shape in listaShapes)
{
    Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
}