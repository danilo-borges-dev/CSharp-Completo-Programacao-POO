namespace Exercício_74.Models.Excetions
{
    internal class InvalidValueException : ApplicationException
    {
        public InvalidValueException(string message) : base (message)
        {

        }
    }
}
