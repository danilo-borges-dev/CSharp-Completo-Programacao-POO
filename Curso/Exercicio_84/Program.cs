using Exercicio_84.Models;
using Exercicio_84.Models.Enums;
using System.Globalization;

string departmentName;
string name;
double baseSalary = new double();
double valurPerHour = new double();
int level = new int();
int qtdContracts = new int();
int duration = new int();
int month = new int();
int year = new int();   
DateTime date = new DateTime();
WorkerLevel workerLevel = new WorkerLevel();

Woker worker;

Console.Write("Enter department's name: ");
departmentName = Console.ReadLine();
Console.WriteLine("Enter worker data: ");
Console.Write("Name: ");
name = Console.ReadLine();
Console.Write("Level (1 - Junior | 2 - Midlevel | 3 - Senior) : ");
level = int.Parse(Console.ReadLine());

if (level == 1)
{
    Enum.TryParse("Junior", out workerLevel);
}
else if (level == 2)
{
    Enum.TryParse("MdLevel", out workerLevel);
}
else
{
    Enum.TryParse("Senior", out workerLevel);
}

Console.Write("Basy Salary $ ");
baseSalary = double.Parse(Console.ReadLine());

worker = new(name, workerLevel, baseSalary, new Department(departmentName));

Console.Write("How many contracts to this worker? ");
qtdContracts = int.Parse(Console.ReadLine());

for (int i = 0; i < qtdContracts; i++)
{
    Console.WriteLine($"\nEnter #{i + 1} contract data: ");
    Console.Write("Date (DD/MM/YYYY): ");
    date = DateTime.Parse(Console.ReadLine());
    Console.Write("Value per hour $ ");
    valurPerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Duration (Hours): ");
    duration = int.Parse(Console.ReadLine());

    worker.AddContract(new HourContract(date, valurPerHour, duration));
}

Console.Write("\nEnter month and year to calculate income (MM/YYYY): ");
date = DateTime.Parse(Console.ReadLine());

month = (int)date.Month;
year = (int)date.Year;

Console.WriteLine("Name: " + worker.Name);
Console.WriteLine("Department: " + worker.Department.Name);
Console.WriteLine($"Income for {month}/{year} $ " + (worker.Income(year, month) + worker.BaseSalary).ToString("F2", CultureInfo.InvariantCulture)); 
