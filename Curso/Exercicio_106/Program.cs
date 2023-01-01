using Exercicio_106.Entities;
using Exercicio_106.Entities.Enums;
using System.Globalization;

string nomeDepartamento;
string nome;
string nivel;
double salarioBase = new double();
int nContratos = new int();
DateTime dataDoContrato = new DateTime();
double valorPorHora = new double();
int quantidadeDeHoras = new int();
DateTime dataRecebimento = new DateTime();
NivelDoTrabalhador enumNivelDoTrabalhador = new NivelDoTrabalhador();
int ano = new int();
int mes = new int();
string mesAno;

Trabalhador trabalhador;

Console.Write("Informe o nome do departamento: ");
nomeDepartamento = Console.ReadLine();
Console.WriteLine("Enter com os dados do trabalhador: ");
Console.Write("Nome: ");
nome = Console.ReadLine();
Console.WriteLine("Nível (Junior | Pleno | Senior): ");
nivel = Console.ReadLine();
Enum.TryParse(nivel, out enumNivelDoTrabalhador);
Console.Write("Salário base: $ ");
salarioBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantos contratos tem este trabalhador? ");
nContratos = int.Parse(Console.ReadLine());

trabalhador = new(nome, enumNivelDoTrabalhador, salarioBase, new Departamento(nomeDepartamento));

for (int i = 0; i < nContratos; i++)
{
    Console.WriteLine($"\nEntre com as informações do #{i + 1} contrato: ");
    Console.Write("Data (dd/MM/AAAA): ");
    dataDoContrato = DateTime.Parse(Console.ReadLine());
    Console.Write("Valor por hora: ");
    valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Duração (horas): ");
    quantidadeDeHoras = int.Parse(Console.ReadLine());

    trabalhador.AddContrato(new ContratoPorHora(dataDoContrato, valorPorHora, quantidadeDeHoras));
}

Console.Write("\nInforme o mês e o ano para calcular o recebimento (mm/YYYY): ");
mesAno = Console.ReadLine();
mes = int.Parse(mesAno.Substring(0, 2));
ano = int.Parse(mesAno.Substring(3));

Console.WriteLine($"\nNome: {trabalhador.Nome}");
Console.WriteLine($"Departamento: {trabalhador.Departamento.Nome}");
Console.WriteLine($"Recebimento $ {trabalhador.Recebimento(mes, ano).ToString("F2", CultureInfo.InvariantCulture)}");