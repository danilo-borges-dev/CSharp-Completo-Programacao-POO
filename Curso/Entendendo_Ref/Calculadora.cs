namespace Entendendo_Ref
{
    internal static class Calculadora
    {
        public static double Salario { get; private set; } = new double();
        public static double AumentarSalario(double salarioAtual, double porcentagem, out double valorDeAumento)
        {
            Salario = salarioAtual;
            valorDeAumento = salarioAtual * (porcentagem / 100);
            Salario += valorDeAumento;
            return Salario;
        }
    }
}
