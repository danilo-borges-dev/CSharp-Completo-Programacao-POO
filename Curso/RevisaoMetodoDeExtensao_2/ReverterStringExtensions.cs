namespace RevisaoMetodoDeExtensao_2
{
    internal static class ReverterStringExtensions
    {
        public static string Reverter(this string valor)
        {
            return new string(valor.ToCharArray().Reverse().ToArray());
        }
    }
}
