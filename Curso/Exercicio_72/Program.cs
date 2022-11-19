using Exercicio_72.Models;
using Exercicio_72.Models.Enums;
using System.Globalization;

string nomeDepartamento;
string nomeTrabalhador;
string nivel;
double salarioBase = new double();
int nContratos = new int();
DateTime dataContrato = new DateTime();
string dataPeriodo;
double valorPorHora = new double();
int duracao = new int();
Niveis enumNivel = new Niveis();
int mes = new int();
int ano = new int();

Trabalhador trabalhador;

Console.Write("Entre com o nome do Departamento: ");
nomeDepartamento = Console.ReadLine();
Console.WriteLine("Dados do Trabalhador:");
Console.Write("Nome: ");
nomeTrabalhador = Console.ReadLine();
Console.Write("Nível (Júnior | Pleno | Senior): ");
nivel = Console.ReadLine();
if (nivel == "Júnior" || nivel == "júnior")
{
    nivel = "Junior";
}

Enum.TryParse(nivel, out enumNivel);

Console.Write("Salário Base $ ");
salarioBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

trabalhador = new(nomeTrabalhador, enumNivel,  salarioBase, new Departamento(nomeDepartamento));

Console.Write("Informe o número de contratos para este trabalhador: ");
nContratos = int.Parse(Console.ReadLine());

for (int i = 0; i < nContratos; i++)
{
    Console.WriteLine($"\nDados do {i + 1}º Contrato:");
    Console.Write("Data (DD/MM/YYYY): ");
    dataContrato = DateTime.Parse(Console.ReadLine());
    Console.Write("Valor por Hora: $ ");
    valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Duração (Horas): ");
    duracao = int.Parse(Console.ReadLine());

    trabalhador.AddContrato(new Contrato(dataContrato, valorPorHora, duracao));
}

Console.Write($"\nInforme um período (Mês e Ano) para calcular o valor total (MM/YYYY): ");
dataPeriodo = Console.ReadLine();

mes = int.Parse(dataPeriodo.Substring(0, 2));
ano = int.Parse(dataPeriodo.Substring(3));

Console.WriteLine($"\nNome: {trabalhador.Nome}");
Console.WriteLine($"Departamento: {trabalhador.Departamento.Nome}");
Console.WriteLine($"Valor Total para o Perído {mes}/{ano}: {trabalhador.RendaTotal(mes, ano).ToString("F2", CultureInfo.InvariantCulture)}");

