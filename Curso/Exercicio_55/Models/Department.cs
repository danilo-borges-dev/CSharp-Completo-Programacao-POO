namespace Exercicio_55.Models
{
    internal class Department
    {
        public string Name { get; private set; }

        public Department(string name)
        {
            Name = name;
        }
    }
}
