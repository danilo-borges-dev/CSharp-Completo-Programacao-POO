using System.Globalization;

double raio = new double();
double circunferencia = new double();
double volume = new double();


Main();

void Main()
{
    Console.Write("Entre com o valor do raio: ");
    raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    circunferencia = Circunferencia.CalcularCircunferencia(raio);
    volume = Volume.CalcularVolume(raio);

    Console.WriteLine("\nCircunferência: " + circunferencia.ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Valor de PI: " + Math.PI.ToString("F2", CultureInfo.InvariantCulture));
}

static class Circunferencia
{
    public static double CalcularCircunferencia(double raio)
    {
        return 2 * Math.PI * raio;
    }
}

static class Volume
{
    public static double CalcularVolume(double raio)
    {
        return 4.0 / 3.0 * Math.PI * Math.Pow(raio, 3);
    }
}