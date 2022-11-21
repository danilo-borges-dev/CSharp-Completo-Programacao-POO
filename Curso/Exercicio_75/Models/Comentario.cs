namespace Exercicio_75.Models
{
    internal class Comentario
    {
        public string Texto { get; private set; }

        public Comentario(string texto)
        {
            Texto = texto;
        }
    }
}
