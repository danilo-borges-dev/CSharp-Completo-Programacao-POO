using Exercicio_60.Models;
using System.Globalization;

int nEmployees = new int();
char yesOrNo = new char();
string employeeName;
int hours = new int();
double additional = new double();
double valuePerhour = new double();

List<Employee> employeeList = new List<Employee>();

Console.Write("Enter the number of employees: ");
nEmployees = int.Parse(Console.ReadLine());

for (int i = 0; i < nEmployees; i++)
{
    Console.WriteLine($"\nEmployee #{i + 1} data: ");
    Console.Write("Outsourced (y/n)? ");
    yesOrNo = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    employeeName = Console.ReadLine();
    Console.Write("Hours: ");
    hours = int.Parse(Console.ReadLine());
    Console.Write("Value per hour: $ ");
    valuePerhour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (yesOrNo == 'y' || yesOrNo == 'Y')
    {
        Console.Write("Additional change: $ ");
        additional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        employeeList.Add(new OutSourcedEmployee(employeeName, hours, valuePerhour, additional));
    }
    else
    {
        employeeList.Add(new Employee(employeeName, hours, valuePerhour));
    }

}

Console.WriteLine("\nPAYMENTS: ");
foreach (Employee employee in employeeList)
{
    Console.WriteLine(employee);
}