namespace Exercicio_68.Models
{
    internal class PessoaJuridica : Pessoa
    {
        public int NumeroFuncionarios { get; private set; } = new int();

        public PessoaJuridica(int numeroFuncionarios, string nome, double rendaAnual) : base (nome, rendaAnual)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }

        public override double CalcularImposto(out double impostoArrecadado)
        {
            if (NumeroFuncionarios > 10)
            {
                impostoArrecadado = RendaAnual * 14 / 100;
                return RendaAnual -= RendaAnual * 14 / 100;
            }
            impostoArrecadado = RendaAnual * 14 / 100;
            return RendaAnual -= RendaAnual * 16 / 100;
        }
    }
}
