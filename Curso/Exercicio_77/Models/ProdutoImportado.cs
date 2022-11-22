using System.Globalization;
using System.Text;

namespace Exercicio_77.Models
{
    internal sealed class ProdutoImportado : Produto
    {
        public double CustoDeImportacao { get; private set; } = new double();

        public ProdutoImportado(double custoDeImportacao, string nome, double valor) : base(nome, valor)
        {
            CustoDeImportacao = custoDeImportacao;
        }

        public override sealed string PrecoTag()
        {
            StringBuilder sb = new();
            sb.Append($"{Nome} $ ");
            sb.Append((Preco + CustoDeImportacao).ToString("F2", CultureInfo.InvariantCulture));
            sb.Append($" (Custos de Importação: $ {CustoDeImportacao.ToString("F2", CultureInfo.InvariantCulture)})");
            return sb.ToString();
        }
    }
}
