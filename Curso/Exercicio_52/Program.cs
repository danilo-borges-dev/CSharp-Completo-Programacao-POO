using Exercicio_52.Models;
using Exercicio_52.Models.Enums;
using System.Globalization;

string nomeDepartamento;
string nomeDoTrabalhador;
int level = new int();
double salarioBase = new double();
int numeroDeContratos = new int();
double valor = new double();

DateTime dateTime = new DateTime();
DateTime anoMes = new DateTime();

double valorPorHora = new double();
int duracao = new int();
WorkerLevel workerLevel = new WorkerLevel();

Worker trabalhador;

Console.Write("Entre com o Nome do Departamento: ");
nomeDepartamento = Console.ReadLine();
Console.WriteLine("Entre com as informações do Trabalhador: ");
Console.Write("Nome: ");
nomeDoTrabalhador = Console.ReadLine();
Console.Write("Lével (1 - Junior, 2 - MideLevel, 3 - Senior : ");
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

Console.Write("Salário Base $ ");
salarioBase = double.Parse(Console.ReadLine());

trabalhador = new(nomeDoTrabalhador, workerLevel, salarioBase, new Department(nomeDepartamento));

Console.Write("\nInforme o número de contratos: ");
numeroDeContratos = int.Parse(Console.ReadLine());

for (int i = 0; i < numeroDeContratos; i++)
{
    HourContract contratoPorHora;

    Console.WriteLine($"\nEntre com as Informações do #{i + 1} Contrato: ");
    Console.Write("Data (DD/MM/YYYY): ");
    dateTime = DateTime.Parse(Console.ReadLine());
    Console.Write("Valor por Hora: ");
    valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Duração (Horas): ");
    duracao = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    contratoPorHora = new(dateTime, valorPorHora, duracao);

    trabalhador.AddContract(contratoPorHora);
}

Console.Write("\nEntre com o Ano e o Mês para calcular o Income (MM/YY): ");
anoMes = DateTime.Parse(Console.ReadLine());

valor = trabalhador.inCome(anoMes.Year, anoMes.Month);

Console.WriteLine(trabalhador);
Console.WriteLine($"Income de {anoMes} : {valor.ToString("F2", CultureInfo.InvariantCulture)}");
