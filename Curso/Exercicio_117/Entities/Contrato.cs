namespace Exercicio_117.Entities
{
    internal class Contrato
    {
        public int Numero { get; private set; }
        public DateTime Date { get; private set; }
        public double ValorTotal { get; private set; }

        private List<Parcela> _parcelas = new List<Parcela>();
        public Contrato(int numero, DateTime date, double valorTotal)
        {
            Numero = numero;
            Date = date;
            ValorTotal = valorTotal;
        }
        public void AdicionarParcela (Parcela parcela)
        {
            _parcelas.Add(parcela);
        }
        public void RemoverParcela (Parcela parcela, DateTime dataDaParcela)
        {
            foreach (var itemDeParcela in _parcelas)
            {
                if (itemDeParcela.DataVencimento.Day == dataDaParcela.Day)
                {
                    _parcelas.Remove(parcela);
                }
            }
        }
    }
}
