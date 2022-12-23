namespace Exercicio_100.Entities
{
    internal class Employee
    {
        public readonly int Id;
        public string Name { get; private set; }
        public double Salary { get; private set; }
        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public double IncreaseSalary(double percet)
        {
            return Salary += Salary * (percet / 100);
        }
    }
}
