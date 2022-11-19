namespace Exercicio_68.Models
{
    internal class PessoaFisica : Pessoa
    {        
        public double GastosSaude { get; private set; } = new double();

        public PessoaFisica(double rendaAnual, double gastosSaude, string nome) : base(nome, rendaAnual)
        {
            GastosSaude = gastosSaude;
        }

        public override double CalcularImposto()
        {
            if (RendaAnual < 20_000)
            {
                if (GastosSaude > 0)
                {
                    return ((RendaAnual * 15 / 100) -  GastosSaude * 50/100);
                }
                else
                {
                    return (RendaAnual * 15 / 100);
                }
            }

            if (RendaAnual > 20_000 && GastosSaude > 0)
            {
                double result = ((RendaAnual * 25 / 100) - GastosSaude * 50 / 100);
                return result;
            }
            return (RendaAnual * 25 / 100);
        }
    }
}
