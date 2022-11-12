using Exercicio_53.Models;
using Exercicio_53.Models.Enums;
using System.Globalization;

string departmentName;
string workerName;
int level = new int();
double baseSalary = new double();
double value = new double();
int nContracts = new int();
int hours = new int();
string yearMonth;
int year = new int();
int month = new int();
DateTime date = new DateTime();
WorkerLevel workerLevel = new WorkerLevel();

Worker worker;

Console.Write("Enter department's name: ");
departmentName = Console.ReadLine();
Console.WriteLine("Enter worker data: ");
Console.Write("Name: ");
workerName = Console.ReadLine();
Console.Write("Level (1 - Junior / 2 - MidLevel / 3 - Senior) : ");
level = int.Parse(Console.ReadLine());

if (level == 1)
{
    workerLevel = WorkerLevel.Junior;
}
else if (level == 2)
{
    workerLevel = WorkerLevel.Mid_level;
}
else
{
    workerLevel = WorkerLevel.Senior;
}

Console.Write("Base Salary $ ");
baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

worker = new(workerName, workerLevel, baseSalary, new Department(departmentName));

Console.Write("\nHow many contracts to this worker? ");
nContracts = int.Parse(Console.ReadLine());

for (int i = 0; i < nContracts; i++)
{
    Console.WriteLine($"\nEnter {i + 1} contract data:");
    Console.Write("Date: ");
    date = DateTime.Parse(Console.ReadLine());
    Console.Write("Value per hour: ");
    value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Duration: ");
    hours = int.Parse(Console.ReadLine());

    worker.AddContract(new HourContract(date, value, hours));
}

Console.Write("\nEnter month and year to calculate income (MM/YYYY): ");
yearMonth = Console.ReadLine();
month = int.Parse(yearMonth.Substring(0, 2));
year = int.Parse(yearMonth.Substring(3));


Console.WriteLine($"\n{worker}");
Console.WriteLine($"Income for {month}/{year}: $ {worker.InCome(year, month).ToString("F2", CultureInfo.InvariantCulture)}");