using System.Globalization;

double raio = new double();
double volume = new double();
double circunferencia = new double();

Main();

void Main()
{
    Console.Write("Entre com o valor do raio: ");
    raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    circunferencia = Circunferencia.CalcularCircunferencia(raio);
    volume = Volume.CalcularVolume(raio);

    // Exibição de String via Console com PlaceHolders
    Console.WriteLine("\nCircunferência: {0}", circunferencia.ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Volume: {0}", volume.ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("PI: {0}", Math.PI.ToString("F2", CultureInfo.InvariantCulture));
}

public static class Circunferencia
{
    public static double CalcularCircunferencia(double raio)
    {
        return 2.0 * Math.PI * raio;
    }
}

public static class Volume
{
    public static double CalcularVolume(double raio)
    {
        return 4.0 / 3.0 * Math.PI * Math.Pow(raio, 3);
    }
}


