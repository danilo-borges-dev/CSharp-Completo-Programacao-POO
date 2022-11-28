namespace Exercicio_80.Models
{
    internal sealed class PessoaFisica : Contribuinte
    {
        public double GastosComSaude { get; private set; } = new double();

        public PessoaFisica(double gastosComSaude, string nome, double rendaAnual) : base(nome, rendaAnual)
        {
            GastosComSaude = gastosComSaude;
        }

        public sealed override double ValorImportoPagar()
        {
            if (RendaAnual < 20_000)
            {
                if (GastosComSaude > 0)
                {
                    TotalTaxes += (RendaAnual * 0.15 - GastosComSaude * 0.50);
                    return (RendaAnual * 0.15 - GastosComSaude * 0.50);
                }
                TotalTaxes += RendaAnual * 0.15;
                return RendaAnual * 0.15;
            }
            if (GastosComSaude > 0)
            {
                TotalTaxes += (RendaAnual * 0.25 - GastosComSaude * 0.50);
                return (RendaAnual * 0.25 - GastosComSaude * 0.50);
            }
            TotalTaxes += RendaAnual * 0.25;
            return RendaAnual * 0.25;
        }
    }
}
