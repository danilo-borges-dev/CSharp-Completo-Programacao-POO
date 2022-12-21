using Exercicio_94;
using Exercicio_94.Entities;
using Exercicio_94.Entities.Enums;
using System.Globalization;

string departmentsName;
int level = new int();
WorkerLevel workerLevel = new WorkerLevel();
double baseSalary = new double();
int nContracts = new int();
DateTime date = new DateTime();
double valuePerHour = new double();
int duration = new int();
string monthAndYear;
int month = new int();
int year = new int();
string name;

Worker worker;

Console.Write("Enter department's name: ");
departmentsName = Console.ReadLine();
Console.WriteLine("Enter worker data: ");
Console.Write("Name: ");
name = Console.ReadLine();
Console.Write("Level (1 - Junior/ 2 - MidLevel/ 3 - Senior): ");
level = int.Parse(Console.ReadLine());

if (level == 1)
{
    workerLevel = WorkerLevel.Junior;
}
else if (level == 2)
{
    workerLevel = WorkerLevel.Mid_Level;
}
else
{
    workerLevel = WorkerLevel.Senior;
}

Console.Write("Base Salary $ ");
baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("How many contracts to this worker? ");
nContracts = int.Parse(Console.ReadLine());

worker = new(name, workerLevel, baseSalary, new Department(departmentsName));

for (int i = 0; i < nContracts; i++)
{
    Console.WriteLine($"\nEnter #{i + 1} contract data: ");
    Console.Write("Date (DD/MM/YYYY): ");
    date = DateTime.Parse(Console.ReadLine());
    Console.Write("Value per hour $ ");
    valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Duration (hours): ");
    duration = int.Parse(Console.ReadLine());

    worker.AddContract(new HourContract(date, valuePerHour, duration));
}

Console.Write("\nEnter month and year to calculate income (MM/YYYY): ");
monthAndYear = Console.ReadLine();
month = int.Parse(monthAndYear.Substring(0,2));
year = int.Parse(monthAndYear.Substring(3));

Console.WriteLine($"Name: {worker.Name}");
Console.WriteLine($"Department: {worker.Department.Name}");
Console.WriteLine($"Income for {month}/{year} $ {worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture)}");