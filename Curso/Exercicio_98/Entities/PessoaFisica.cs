namespace Exercicio_98.Entities
{
    internal sealed class PessoaFisica : Pessoa
    {
        public double GastosComSaude { get; private set; }

        public PessoaFisica(string nome, double rendaAnual, double gastosComSaude) : base (nome, rendaAnual)
        {
            GastosComSaude = gastosComSaude;
        }
        public override double CalcularImposto()
        {
            if (RendaAnual < 20_000)
            {
                if (GastosComSaude > 0)
                {
                    return (RendaAnual * 0.15) - GastosComSaude * 0.5;
                }
                return RendaAnual * 0.15;
            }
            if (RendaAnual >= 20_000)
            {
                if (GastosComSaude > 0)
                {
                    return (RendaAnual * 0.25) - GastosComSaude * 0.5;
                }
            }
            return RendaAnual * 0.25;
        }
    }
}
