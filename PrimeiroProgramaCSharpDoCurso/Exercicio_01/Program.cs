Pessoa p1 = new();
Pessoa p2 = new();

Console.WriteLine("Dados da primeira pessoa: ");
Console.Write("Nome: ");
p1.Nome = Console.ReadLine();
Console.Write("Idade: ");
p1.Idade = int.Parse(Console.ReadLine());

Console.WriteLine("Dados da segunda pessoa: ");
Console.Write("Nome: ");
p2.Nome = Console.ReadLine();
Console.Write("Idade: ");
p2.Idade = int.Parse(Console.ReadLine());

p1.VerificarPessoaMaisVelha(p1.Nome, p1.Idade, p2.Nome, p2.Idade);

class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public void VerificarPessoaMaisVelha(string nome1, int idade1, string nome2, int idade2)
    {
        if (idade1 > idade2)
        {
            Console.WriteLine($"Pessoa mais velha: {nome1}");
        }
        else
        {
            Console.WriteLine($"Pessoa mais velha: {nome2}");
        }
    }
}
