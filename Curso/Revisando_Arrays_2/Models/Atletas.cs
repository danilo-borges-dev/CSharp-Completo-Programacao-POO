namespace Revisando_Arrays_2.Models
{
    internal class Atletas : IComparable<Atletas>
    {
        public int Id { get; private set; } = new int();
        public double Peso { get; private set; } = new double();
        public string Nome { get; private set; }

        public Atletas(int id, double peso, string nome)
        {
            Id = id;
            Peso = peso;
            Nome = nome;
        }

        public int CompareTo(Atletas? other)
        {
            if (this.Id == other.Id)
            {
                return 0;
            }
            if (this.Id > other.Id)
            {
                return 1;
            }
            return -1;
        }
    }
}
