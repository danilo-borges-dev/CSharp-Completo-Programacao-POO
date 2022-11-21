namespace Exercicio_73.Models.Exceptions
{
    internal class InvalidDateException : ApplicationException
    {
        public InvalidDateException(string message) : base(message)
        {

        }
    }
}
