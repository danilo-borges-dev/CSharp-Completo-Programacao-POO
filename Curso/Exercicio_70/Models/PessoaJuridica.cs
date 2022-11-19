namespace Exercicio_70.Models
{
    internal sealed class PessoaJuridica : Pessoa
    {
        public int QuantidadeFuncionarios { get; private set; } = new int();

        public PessoaJuridica(string nome, double rendaAnual, int quantidadeFuncionarios) : base (nome, rendaAnual)
        {
            QuantidadeFuncionarios = quantidadeFuncionarios;
        }

        public sealed override double CalcularImposto()
        {
            if (QuantidadeFuncionarios > 10)
            {
                return RendaAnual * 14 / 100;
            }
            return RendaAnual * 16 / 100;
        }
    }
}
