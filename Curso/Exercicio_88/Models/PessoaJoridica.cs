namespace Exercicio_88.Models
{
    internal sealed class PessoaJoridica : Contribuinte
    {
        public int QuantidadeDeFuncionarios { get; private set; }

        public PessoaJoridica(string nome, double rendaAnual, int quantidadeDeFuncionarios) : base (nome, rendaAnual)
        {
            QuantidadeDeFuncionarios = quantidadeDeFuncionarios;
        }
        public override double CalcularImposto()
        {
            if (QuantidadeDeFuncionarios > 10)
            {
                return this.RendaAnual * 0.14;
            }
            return this.RendaAnual * 0.16;
        }
    }
}
