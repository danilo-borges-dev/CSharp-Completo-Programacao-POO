namespace RevisaoMetodosDeExtensao
{
    internal static class InverterStringExtensions
    {
        public static string Reverter(this string msg)
        {
            return new string(msg.ToCharArray().Reverse().ToArray());
        }
    }
}
