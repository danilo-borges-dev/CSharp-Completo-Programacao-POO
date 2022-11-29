namespace Exercicio_83.Models.Exceptions
{
    internal class NegativeValueExcetion : ApplicationException
    {
        public NegativeValueExcetion (string message) : base (message)
        {

        }
    }
}
