namespace MetodoDeEstensao
{
    internal static class RevertStringExtensions
    {
        static char[] s;
        public static string Revert(this string valor)
        {
            return new string(valor.ToCharArray().Reverse().ToArray());
        }
    }
}
