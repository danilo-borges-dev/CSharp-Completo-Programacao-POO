namespace Exercicio_112.Entities
{
    internal sealed class PessoaJuridica : Pessoa
    {
        public int QuantidadeDeFuncionarios { get; private set; }
        public PessoaJuridica(string nome, double rendaAnual, int quantidadeDeFuncionarios) : base (nome, rendaAnual)
        {
            QuantidadeDeFuncionarios = quantidadeDeFuncionarios;
        }
        public override double CalcularImporto()
        {
            if (QuantidadeDeFuncionarios >= 10)
            {
                return RendaAnual * 0.14;
            }
            return RendaAnual * 0.16;
        }
    } 
}
