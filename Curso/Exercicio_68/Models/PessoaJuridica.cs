namespace Exercicio_68.Models
{
    internal class PessoaJuridica : Pessoa
    {
        public int NumeroFuncionarios { get; private set; } = new int();

        public PessoaJuridica(int numeroFuncionarios, string nome, double rendaAnual) : base (nome, rendaAnual)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }

        public override double CalcularImposto()
        {
            if (NumeroFuncionarios > 10)
            {
                return(RendaAnual * 14 / 100);
            }
            return (RendaAnual * 16 / 100);
        }
    }
}
