namespace MembrosEstaticos
{
    internal static class CalculaDesconto
    {
        private static double _valorDeDesconto = new double();

        public static void DefinirValorDeDesconto(double value)
        {
            _valorDeDesconto = value;
        }

        public static double AplicarDesconto(double valorDaCompra)
        {
            valorDaCompra -= _valorDeDesconto;
            return valorDaCompra;
        }
    }
}
