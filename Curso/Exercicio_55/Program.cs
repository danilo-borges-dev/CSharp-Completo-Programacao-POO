using Exercicio_55.Models;
using Exercicio_55.Models.Enums;
using System.Globalization;

string departmentsName;
string workerName;
int level = new int();
double baseSalary = new double();
int nContracts = new int();
double valuePerHour = new double();
int duration = new int();
WorkerLevel workerLevel = new WorkerLevel();    
DateTime dateContract = new DateTime();
int month = new int();
int year = new int();
string dateMonthYear;

Worker worker;

Console.Write("Enter department's name: ");
departmentsName = Console.ReadLine();
Console.WriteLine("Enter worker data: ");
Console.Write("Name: ");
workerName = Console.ReadLine();
Console.Write("Level (1 - Junior | 2 - MidLevel | 3 - Senior) : ");
level = int.Parse(Console.ReadLine());


if (level == 1)
{
    workerLevel = WorkerLevel.Junior;
}
else if (level == 2)
{
    workerLevel = WorkerLevel.Md_Level;
}
else
{
    workerLevel = WorkerLevel.Senior;
}

Console.Write("Base Salary $ ");
baseSalary = double.Parse(Console.ReadLine());

worker = new(workerLevel, baseSalary, new Department(departmentsName), workerName);

Console.Write("\nHow many contracs to this worker? ");
nContracts = int.Parse(Console.ReadLine());

for (int i = 0; i < nContracts; i++)
{
    Console.WriteLine($"Enter #{i + 1} contract data:");
    Console.Write("Date (DD/MM/YYYY): ");
    dateContract = DateTime.Parse(Console.ReadLine());
    Console.Write("Value per hour $ ");
    valuePerHour = double.Parse((string)Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Duration: ");
    duration = int.Parse(Console.ReadLine());

    worker.AddContract(new HourContract(dateContract, valuePerHour, duration));
}

Console.Write("\nEnter moth and year to calculete income (MM/YYYY): ");
dateMonthYear = Console.ReadLine();

month = int.Parse(dateMonthYear.Substring(0, 3));
year = int.Parse(dateMonthYear.Substring(3));

Console.WriteLine($"\nName: {worker.Name}");
Console.WriteLine($"Department: {worker.Department.Name}");
Console.WriteLine($"Income for {dateMonthYear} : $ {worker.InCome(month, year).ToString("F2", CultureInfo.InvariantCulture)}");