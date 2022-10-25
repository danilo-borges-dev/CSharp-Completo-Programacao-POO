string[] nome = new string[2];
int[] idade = new int[2];

for (int i = 0; i < 2; i++)
{
    Console.WriteLine($"Dados da {i + 1}ª pessoa:");
    Console.Write("Nome: ");
    nome[i] = Console.ReadLine();
    Console.Write("Idade: ");
    idade[i] = int.Parse(Console.ReadLine());
}

if (idade[0] > idade[1])
{
    Console.WriteLine($"\nPessoa mais velha: {nome[0]}");
}
else
{
    Console.WriteLine($"\nPessoa mais velha: {nome[1]}");
}