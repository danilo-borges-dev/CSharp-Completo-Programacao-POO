using Exercicio_39;

string nomeEstudante;
string emailEstudante;
int numeroDoQuarto = new int();
int qtdEstudantes = new int();
Quarto[] quartos = new Quarto[10];

Console.Write("Quantos Estudantes irão se Hospedar (de 1 ao máximo 10): ");
qtdEstudantes = int.Parse(Console.ReadLine());

for (int i = 0; i < qtdEstudantes; i++)
{
    bool situacaoQuarto = true;
    do
    {
        Console.Write("\nNúmero do Quarto: ");
        numeroDoQuarto = int.Parse(Console.ReadLine());


        if (quartos[numeroDoQuarto - 1] == null)
        {
            situacaoQuarto = false;
            Console.Write($"\nInforme o Nome do {i + 1}º Aluno: ");
            nomeEstudante = Console.ReadLine();
            Console.Write("Informe o E-mail: ");
            emailEstudante = Console.ReadLine();

            quartos[numeroDoQuarto - 1] = new Quarto(nomeEstudante, emailEstudante);

            situacaoQuarto = false;
        }
        else
        {
            Console.WriteLine("O quarto já está Ocupado. Tente outro.");
        }

    } while (situacaoQuarto);
}

Console.WriteLine(" ");

for (int i = 0; i < 10; i++)
{
    if (quartos[i] != null)
    {
        Console.WriteLine($"Quarto nº {i + 1} - {quartos[i].Nome}, {quartos[i].Email}");
    }
}