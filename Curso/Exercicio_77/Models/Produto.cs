using System.Text;
using System.Globalization;

namespace Exercicio_77.Models
{
    internal class Produto
    {
        public string Nome { get; protected set; }
        public double Preco { get; protected set; } = new double();

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public virtual string PrecoTag()
        {
            StringBuilder sb = new();
            sb.Append(Nome);
            sb.Append($" $ {Preco.ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}
