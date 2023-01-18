using Exercicio_118.Entities;
using Exercicio_118.Entities.Enums;
using System.Globalization;
using static System.Console;

string department = string.Empty;
string woerkerName = string.Empty;
string level = string.Empty;
double salary = new double();
int nContracts = new int();
double valuePerHour = new double();
int duration = new int();
int month = new int();
int year = new int();
string monthAndYear = string.Empty;
DateTime contractDate = new DateTime();

EWorkerLevel workerLevel = new EWorkerLevel();
Worker worker;

Write("Enter department's name: ");
department = ReadLine();
WriteLine("Enter worker data: ");
Write("Name: ");
woerkerName = ReadLine();
Write("Level (Junior/MidLevel/Senior): ");
level = ReadLine();
Enum.TryParse(level, out workerLevel);
Write("Base salary $ ");
salary = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
Write("How many contracts to this worker? ");
nContracts = int.Parse(ReadLine());

worker = new(name: woerkerName, workerLevel: workerLevel, baseSalary: salary, department: new Department(name: department));

for (int i = 0; i < nContracts; i++)
{
    WriteLine($"\nEnter #{i + 1} contract data: ");
    Write("Date (DD/MM/YYYY0): ");
    contractDate = DateTime.Parse(ReadLine());
    Write("Value per hour: ");
    valuePerHour = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
    Write("Duration (Hours): ");
    duration = int.Parse(ReadLine());

    worker.AddContract(new HourContract(date: contractDate, valuePerHour: valuePerHour, hours: duration));
}

Write("\nEnter month and year to calculate income (MM/YYYY): ");
monthAndYear = ReadLine();

month = int.Parse(monthAndYear.Substring(0, 2));
year = int.Parse(monthAndYear.Substring(3));
WriteLine($"Name {worker.Name}");
WriteLine($"Department: {worker.Department.Name}");
WriteLine($"Income for {month}/{year} $ {worker.Income(month: month, year: year).ToString("F2", CultureInfo.InvariantCulture)}");
