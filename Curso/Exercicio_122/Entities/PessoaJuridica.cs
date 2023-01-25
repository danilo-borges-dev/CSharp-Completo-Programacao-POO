namespace Exercicio_122.Entities
{
    internal sealed class PessoaJuridica : Pessoa
    {
        public int QtdFuncionarios { get; private set; } = new int();
        public PessoaJuridica(string nome, double rendaAnual, int qtdFuncionarios) : base (nome, rendaAnual)
        {
            QtdFuncionarios = qtdFuncionarios;
        }
        public override double CalcularImpostos()
        {
            if (QtdFuncionarios > 10)
            {
                return RendaAnual * 0.14;
            }
            return RendaAnual * 0.16;
        }
    }
}
