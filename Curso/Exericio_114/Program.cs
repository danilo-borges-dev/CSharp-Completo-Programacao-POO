using Exericio_114.Entities;
using System.Globalization;

List<Funcionario> listaDeFuncionarios = new List<Funcionario>();

Console.Write("How many employees will be registered? ");
int nEmployees = int.Parse(Console.ReadLine());
for (int i = 0; i < nEmployees; i++)
{
    Console.WriteLine($"\nEmployee #{i + 1}: ");
    Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Salary $ ");
    double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    listaDeFuncionarios.Add(new Funcionario(id, name, salary));
}

Console.WriteLine("\nEmployees: ");

foreach (var employee in listaDeFuncionarios)
{
    Console.WriteLine($"{employee.Id} - {employee.Nome}, $ {employee.Salario.ToString("F2", CultureInfo.InvariantCulture)}");
}

bool situation = true;
do
{
    Console.WriteLine("\nEnter the employee ID that will have salary increase: ");
    int idEmployee = int.Parse(Console.ReadLine());

    foreach (var employeeId in listaDeFuncionarios)
    {
        if (employeeId.Id == idEmployee)
        {
            Console.Write("Enter percentage: ");
            double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            employeeId.CalcularAumento(percentage);
            situation = false;
        }
    }

    if (situation == true)
    {
        Console.WriteLine("Employee not exist.\nTray again.");
    }

} while (situation);

Console.WriteLine("\nUpdated list of employees: ");
foreach (var employee in listaDeFuncionarios)
{
    Console.WriteLine($"{employee.Id} - {employee.Nome}, $ {employee.Salario.ToString("F2", CultureInfo.InvariantCulture)}");
}

