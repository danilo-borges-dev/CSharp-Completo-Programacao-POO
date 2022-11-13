namespace Exercicio_55.Models
{
    internal abstract class Person
    {
        public string Name { get; set; }

        protected Person(string name)
        {
            Name = name;
        }
    }
}
