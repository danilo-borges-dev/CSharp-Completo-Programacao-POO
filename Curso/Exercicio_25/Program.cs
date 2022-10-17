string[] nomes = new string[2];
int[] idades = new int[2];

for (int i = 0; i < 2; i++)
{
    Console.WriteLine($"Dados da {i + 1}º pessoa: ");
    Console.Write("Nome: ");
    nomes[i] = Console.ReadLine();
    Console.Write("Idade: ");
    idades[i] = int.Parse(Console.ReadLine());
    Console.WriteLine();
}

if (idades[0] > idades[1])
{
    Console.WriteLine($"Pessoa mais velha {nomes[0]}");
}
else
{
    Console.WriteLine($"Pessoa mais velha {nomes[1]}");
}