using Exercicio_90.Models;
using System.Globalization;

int nEmployees = new int();
string name;
int id = new int();
double salary = new double();
bool condition = true;
double percentage = new double();
double novoSalario = new double();

List<Funcionarios> funcionarios = new List<Funcionarios>();

Console.Write("How many employees will be registred? ");
nEmployees = int.Parse(Console.ReadLine());

for (int i = 0; i < nEmployees; i++)
{
    Console.WriteLine($"\nEmployee #{i + 1}: ");
    Console.Write("Name: ");
    name = Console.ReadLine();

    do
    {
        Console.Write("ID: ");
        id = int.Parse(Console.ReadLine());

        foreach (Funcionarios funcionario in funcionarios)
        {
            if (funcionario.GetId() != null)
            {
                if (funcionario.GetId() == id)
                {
                    Console.WriteLine("ID only exist. Try other.");
                }
            }
            else
            {
                condition = false;
            }
        }

        if (funcionarios.Count == 0)
        {
            condition = false;
        }

    } while (condition);


    Console.Write("Salary $ ");
    salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    funcionarios.Add(new Funcionarios(id, name, salary));
}

condition = true;

foreach (Funcionarios funcionario in funcionarios)
{
    Console.WriteLine($"{funcionario.GetId()} ID - {funcionario.Nome}, $ {funcionario.Salario.ToString("F2", CultureInfo.InvariantCulture)}");
}

do
{
    bool idNotExist = false;

    Console.Write("\nEnter the employee ID that will salary increase: ");
    id = int.Parse(Console.ReadLine());

    foreach (Funcionarios funcionario in funcionarios)
    {
        if (funcionario.GetId() != null)
        {
            if (funcionario.GetId() == id)
            {
                Console.Write("\nEnter the percentage: ");
                percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                funcionario.AumentarSalario(percentage);
                idNotExist = false;      
                condition = false;
            }
        }
    }

    if (idNotExist)
    {
        Console.WriteLine("ID not exist. Try other.");
    }

} while (condition);



foreach (Funcionarios funcionario in funcionarios)
{
    Console.WriteLine($"{funcionario.GetId()} ID - {funcionario.Nome}, $ {funcionario.Salario.ToString("F2", CultureInfo.InvariantCulture)}");
}