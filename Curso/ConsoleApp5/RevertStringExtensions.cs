namespace ConsoleApp5
{
    internal static class RevertStringExtensions
    {
        public static string Reverter (this string value)
        {
            return new string(value.ToCharArray().Reverse().ToArray());
        }
    }
}
