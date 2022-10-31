namespace Revisando_Params
{
    internal static class Calculadora
    {
        public static int SomaResultado { get; private set; } = new int();
        public static int Somar(params int[] valor)
        {
            for (int i = 0; i < valor.Length; i++)
            {
                SomaResultado += valor[i];
            }
            return SomaResultado;   
        }
    }
}
