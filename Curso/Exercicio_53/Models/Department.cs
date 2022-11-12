namespace Exercicio_53.Models
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
