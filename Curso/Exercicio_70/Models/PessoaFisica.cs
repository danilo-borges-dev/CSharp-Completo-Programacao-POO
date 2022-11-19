namespace Exercicio_70.Models
{
    internal sealed class PessoaFisica : Pessoa
    {
        public double GastosComSaude { get; private set; } = new double();

        public PessoaFisica(string nome, double rendaAnual, double gastosComSaude) : base(nome, rendaAnual)
        {
            GastosComSaude = gastosComSaude;
        }

        public sealed override double CalcularImposto()
        {
            if (RendaAnual < 20_000)
            {
                if (GastosComSaude > 0)
                {
                    return (RendaAnual * 15 / 100 - GastosComSaude * 50 / 100);
                }
                return RendaAnual * 15 / 100;
            }

            if (RendaAnual > 20_000 && GastosComSaude > 0)
            {
                return (RendaAnual * 25 / 100 - GastosComSaude * 50 / 100);
            }
            return RendaAnual * 25 / 100;
        }
    }
}
