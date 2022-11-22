namespace Exercicio_76.Models.Exceptions
{
    internal class ValorDinheiroInvalidoException : ApplicationException
    {
        public ValorDinheiroInvalidoException(string menssagem) : base (menssagem)
        {

        }
    }
}
