namespace Exercicio_115.Exceptions
{
    internal class InvalidAmmountException : ApplicationException
    {
        public InvalidAmmountException(string menssage)  : base (menssage)
        {        
        }
    }
}
