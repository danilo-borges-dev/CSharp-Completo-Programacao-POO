namespace ClasseEstatica2
{
    internal class Calculadora
    {
        public double PI = 3.14;
        public double Circunferencia(double raio)
        {
            return 2.0 * PI * raio;
        }

        public double Volume(double raio)
        {
            return 4.0 / 3.0 * PI * raio * raio * raio;
        }
    }
}
