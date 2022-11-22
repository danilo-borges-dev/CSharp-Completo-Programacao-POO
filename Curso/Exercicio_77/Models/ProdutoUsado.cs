using System.Globalization;
using System.Text;

namespace Exercicio_77.Models
{
    internal sealed class ProdutoUsado : Produto
    {
        public DateTime DataDeProducao { get; private set; } = new DateTime();

        public ProdutoUsado(DateTime dataDeProducao, string nome, double valor) : base(nome, valor)
        {
            DataDeProducao = dataDeProducao;
        }
        public override sealed string PrecoTag()
        {
            StringBuilder sb = new();
            sb.Append($"{Nome} (used) $ ");
            sb.Append(Preco.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append($" (Data de Fabricação: {DataDeProducao.ToString("dd/MM/yyyy")})");
            return sb.ToString();
        }
    }
}
