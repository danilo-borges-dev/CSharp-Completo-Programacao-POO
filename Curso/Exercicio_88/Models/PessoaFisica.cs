namespace Exercicio_88.Models
{
    internal sealed class PessoaFisica : Contribuinte
    {
        public double GastosComSaude { get; private set; }

        public PessoaFisica(string nome, double rendaAnual, double gastosComSaude) : base(nome, rendaAnual)
        {
            GastosComSaude = gastosComSaude;
        }
        public override double CalcularImposto()
        {
            if (this.RendaAnual < 20_000)
            {
                if (GastosComSaude > 0)
                {
                    return (this.RendaAnual * 0.15) - (GastosComSaude * 0.50);
                }
                return RendaAnual * 0.15;
            }
            if (GastosComSaude > 0)
            {
                return (this.RendaAnual * 0.25) - (GastosComSaude * 0.50);
            }
            return RendaAnual * 0.25;
        }
    }
}
