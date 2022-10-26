namespace RevisaoMetodoDeExtensao_3
{
    internal static class ReverterExtensions
    {
        public static string Reverter(this string valor)
        {
            return new string(valor.ToCharArray().Reverse().ToArray());
        }
    }
}
