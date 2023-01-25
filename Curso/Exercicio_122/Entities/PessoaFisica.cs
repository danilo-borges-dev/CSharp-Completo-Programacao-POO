namespace Exercicio_122.Entities
{
    internal sealed class PessoaFisica : Pessoa
    {
        public double GastosSaude { get; private set; } = new double();

        public PessoaFisica(string nome, double rendaAnual, double gastosSaude) : base(nome, rendaAnual)
        {
            GastosSaude = gastosSaude;
        }
        public override double CalcularImpostos()
        {
            if (GastosSaude > 0.0)
            {
                if (RendaAnual < 20_000)
                {
                    return (RendaAnual * 0.15) - (GastosSaude * 0.50);
                }
                return (RendaAnual * 0.25) - (GastosSaude * 0.50);
            }

            if (RendaAnual < 20_000)
            {
                return (RendaAnual * 0.15);
            }
            else
            {
                return (RendaAnual * 0.25);
            }
        }
    }
}
