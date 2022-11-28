namespace Exercicio_80.Models
{
    internal sealed class PessoaJuridica : Contribuinte
    {
        public int QuantidadeFuncionarios { get; private set; }

        public PessoaJuridica(string nome, double rendaAnual, int quantidadeFuncionarios) : base (nome, rendaAnual)
        {
            QuantidadeFuncionarios = quantidadeFuncionarios;
        }

        public sealed override double ValorImportoPagar()
        {
            if (QuantidadeFuncionarios > 10)
            {
                TotalTaxes += RendaAnual * 0.14;
                return RendaAnual * 0.14;
            }
            TotalTaxes += RendaAnual * 0.16;
            return RendaAnual * 0.16;
        }
    }
}
