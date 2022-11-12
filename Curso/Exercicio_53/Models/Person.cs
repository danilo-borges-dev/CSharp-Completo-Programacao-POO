namespace Exercicio_53.Models
{
    internal abstract class Person
    {
        protected string Name { get;  set; }

        public Person(string name)
        {
            Name = name;
        }
    }
}
