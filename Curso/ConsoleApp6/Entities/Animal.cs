namespace ConsoleApp6.Entities
{
    internal class Animal : IEquatable<Animal>
    {
        public string Raca { get; private set; }
        public string Tipo { get; private set; }
        public int Idade { get; private set; }
        public Animal(string raca, string tipo, int idade)
        {
            Raca = raca;
            Tipo = tipo;
            Idade = idade;
        }

        public bool Equals(Animal? other)
        {
            if (this.Raca == other.Raca && this.Tipo == other.Tipo && this.Idade == other.Idade)
            {
                return true;
            }
            return false;
        }
    }
}
