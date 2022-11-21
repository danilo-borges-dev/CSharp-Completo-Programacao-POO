using System.Text;

namespace Exercicio_75.Models
{
    internal class Postagem
    {
        public DateTime Momento { get; private set; } = new DateTime();
        public string Titolo { get; private set; }
        public string Mensagem { get; private set; }
        public int Curtidas { get; private set; } = new int();

        public List<Comentario> Comentario = new List<Comentario>();

        public Postagem(DateTime momento, string titolo, string mensagem, int curtidas)
        {
            Momento = momento;
            Titolo = titolo;
            Mensagem = mensagem;
            Curtidas = curtidas;
        }

        public void AdicionarComentario(Comentario comentario)
        {
            Comentario.Add(comentario);
        }

        public void RemoverComentario(Comentario comentario)
        {
            Comentario.Remove(comentario);
        }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine(Titolo);
            sb.Append(Curtidas);
            sb.Append(" Curtidas -");
            sb.AppendLine(Momento.ToString());
            sb.AppendLine("Comentários: ");
            foreach (Comentario comentario in Comentario)
            {
                sb.AppendLine(comentario.Texto);
            }
            return sb.ToString();
        }
    }
}
