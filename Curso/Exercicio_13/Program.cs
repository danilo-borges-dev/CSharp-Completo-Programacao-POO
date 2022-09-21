using Exercicio_13;

List<Pessoa> pessoaList = new();

for (int i = 0; i <= 1; i++)
{
    Console.WriteLine($"Dados da {i + 1}º pessoa: ");
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Idade: ");
    int idade = int.Parse(Console.ReadLine());

    pessoaList.Add(new Pessoa(nome, idade));
}


if (pessoaList[0].Getidade() > pessoaList[1].Getidade())
{
    Console.Write($"Pessoa mais velha: {pessoaList[0].GetNome()}");
}
else
{
    Console.Write($"Pessoa mais velha: {pessoaList[1].GetNome()}");
}
