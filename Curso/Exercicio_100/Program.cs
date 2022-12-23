using Exercicio_100.Entities;
using System.Globalization;
using System.Collections.Generic;

int nEmployees = new int();
int id = new int();
string name;
double salary = new double();
bool condition = true;
double percentage = new double();

List<Employee> employees= new List<Employee>();

Console.Write("How many employees will be registred? ");
nEmployees = int.Parse(Console.ReadLine());

for (int i = 0; i < nEmployees; i++)
{
    Console.WriteLine($"\nEmployee #{i + 1} data:");
    Console.Write("Id: ");
    id = int.Parse(Console.ReadLine());
    Console.Write("Name: ");
    name = Console.ReadLine();
    Console.Write("Salary $ ");
    salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    employees.Add(new Employee(id, name, salary));
}

Console.WriteLine("\n");

foreach (Employee employee in employees)
{
    Console.WriteLine($"ID [{employee.Id}] - {employee.Name} $ {employee.Salary.ToString("F2", CultureInfo.InvariantCulture)}");
}


do
{
    Console.Write("\nEnter the employee ID that will be salary increase: ");
    id = int.Parse(Console.ReadLine());

    foreach (Employee employee in employees)
    {
        if (id == employee.Id)
        {
            Console.Write("Enter the percentage: ");
            percentage = double.Parse(Console.ReadLine());
            employee.IncreaseSalary(percentage);
            condition = false;
        }
    }
    if (condition == true)
    {
        Console.WriteLine("\nID not exsit. \nTry again.");
    }

} while (condition);

Console.WriteLine("Updated list of employees: ");
foreach (Employee employee in employees)
{
    Console.WriteLine($"ID [{employee.Id}] - {employee.Name} $ {employee.Salary.ToString("F2", CultureInfo.InvariantCulture)}");
}