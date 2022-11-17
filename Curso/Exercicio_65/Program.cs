using Exercicio_65.Models;

int qtdEstudantes = new int();
bool condicao = true;
int nQuarto = new int();
string nome;
string email;
Quarto[] quartos = new Quarto[9];

Console.Write("Informe a quantidade de estudantes: ");

do
{
    qtdEstudantes = int.Parse(Console.ReadLine());

    if (qtdEstudantes > 10)
    {
        Console.WriteLine("\nTemos apenas 10 quartos vagos.\nInforme uma nova quantidade de Estudantes.");
    }
    else
    {
        condicao = false;
    }

} while (condicao);


condicao = true;

for (int i = 0; i < qtdEstudantes; i++)
{
    Console.WriteLine($"\nCadastro do {i + 1}º Estudante: ");
    Console.Write("Nome: ");
    nome = Console.ReadLine();
    Console.Write("E-mail: ");
    email = Console.ReadLine();

    Console.Write("Informe o número do quarto: ");
    do
    {
        nQuarto = int.Parse(Console.ReadLine());

        foreach (Quarto quarto in quartos)
        {
            if (quartos[i - 1] != null)
            {
                Console.WriteLine($"Quarto {nQuarto} Ocupado.\nInforme outro:");
                break;
            }
            else
            {
                condicao = false;
                quartos[i] = new Quarto(nQuarto, new Estudante(nome, email));
                break;
            }
        }
    } while (condicao);
}

for (int i = 0; i < qtdEstudantes; i++)
{
    if (quartos[i] != null)
    {

        Console.WriteLine($"{quartos[i].Numero} - Nome: {quartos[i].Estudante.Name}, E-mail: {quartos[i].Estudante.Email}");
    }
}
