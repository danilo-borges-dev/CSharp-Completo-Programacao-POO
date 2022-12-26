namespace Exercicio_102.Exceptions
{
    internal class InvalidValueException : ApplicationException
    {
        public InvalidValueException(string message) : base (message) { }
    }
}
