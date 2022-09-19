using System.Globalization;

double raio = new double();
double circunferencia = new double();
double volume  = new double();
const double PI = Math.PI;

Main();


void Main()
{
    Console.Write("Entre o valor do raio: ");
    raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    CalcularCicunferencia();
    CalcularVolume();

    Console.WriteLine($"Circunferência: {circunferencia.ToString("F2", CultureInfo.InvariantCulture)}");
    Console.WriteLine($"Valume: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
    Console.WriteLine($"Valor de PI: {PI.ToString("F2", CultureInfo.InvariantCulture)}");
}

void CalcularCicunferencia()
{
    circunferencia = 2 * PI * raio;
}

void CalcularVolume()
{
    volume = 4 * PI * Math.Pow(raio, 3) / 3;
}

