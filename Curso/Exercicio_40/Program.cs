using Exercicio_40;

Estudante[] quartosEstudante = new Estudante[10];
int qtdEstudantes = new int();
string nomeEstudante;
string emailEstudante;
int numeroQuarto = new int();
bool situacaoQuarto = true;

Console.Write("Quantos Estudades vão se Hospedar? (1 no máximo 10):  ");
qtdEstudantes = int.Parse(Console.ReadLine());

for (int i = 0; i < qtdEstudantes; i++)
{
    Console.Write($"\nNome do {i + 1}° Estudante: ");
    nomeEstudante = Console.ReadLine();
    Console.Write("E-mail: ");
    emailEstudante = Console.ReadLine();

    do
    {
        Console.Write("\nInforme o número do quarto: ");
        numeroQuarto = int.Parse(Console.ReadLine());

        if (quartosEstudante[numeroQuarto] == null)
        {
            quartosEstudante[i] = new Estudante(nomeEstudante, emailEstudante);
            situacaoQuarto = false;
        }
        else
        {
            Console.WriteLine("Quarto está ocupado.");
            situacaoQuarto = true;
        }

    } while (situacaoQuarto);
}

for (int i = 0; i < qtdEstudantes; i++)
{
    if (quartosEstudante[i] != null)
    {
        Console.WriteLine($"Quarto nº{i + 1} - Nome: {quartosEstudante[i].Nome}, E-mail: {quartosEstudante[i].Email}");
    }
}

