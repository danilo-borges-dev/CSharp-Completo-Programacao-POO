using System.Collections.Generic;

List<string> listaDeNome = new List<string>() { "Danilo", "João", "Marcela", "Anelize" };

listaDeNome.Add("Renata");
listaDeNome.Add("Bob");
listaDeNome.Add("Ana");
listaDeNome.Insert(0, "Marco");

foreach (var item in listaDeNome)
{
    Console.WriteLine(item);
}

Console.WriteLine(listaDeNome.Count());

Console.WriteLine("-----------------------------------------------------------------------------------------------------------");

string s1 = listaDeNome.Find(x => x[0] == 'A');
Console.WriteLine(s1);

Console.WriteLine("-----------------------------------------------------------------------------------------------------------");

s1 = listaDeNome.Find(Test);
Console.WriteLine(s1);

static bool Test(string s)
{
    return s[0] == 'A';
}

Console.WriteLine("-----------------------------------------------------------------------------------------------------------");

s1 = listaDeNome.FindLast(x => x[0] == 'A');
Console.WriteLine(s1);

Console.WriteLine("-----------------------------------------------------------------------------------------------------------");

int indexPos = listaDeNome.FindIndex(x => x[0] == 'A');
Console.WriteLine(indexPos);

Console.WriteLine("-----------------------------------------------------------------------------------------------------------");

indexPos = listaDeNome.FindLastIndex(x => x[0] == 'R');
Console.WriteLine(indexPos);

Console.WriteLine("-----------------------------------------------------------------------------------------------------------");

// Quero encontrar na lista de nomes, todos os elementos/nomes tal que o tamanho da string seja 5,
// e vou armazená-la em outra lista de nomes.
List<string> novaListaDeNomes = listaDeNome.FindAll(x => x.Length == 7);
foreach (var item in novaListaDeNomes)
{
    Console.WriteLine(item);
}

Console.WriteLine("-----------------------------------------------------------------------------------------------------------");

listaDeNome.Remove("Marcela");
foreach (var item in listaDeNome)
{
    Console.WriteLine(item);
}

Console.WriteLine("-----------------------------------------------------------------------------------------------------------");

listaDeNome.RemoveAll(x => x[0] == 'A');
foreach (var item in listaDeNome)
{
    Console.WriteLine(item);
}

Console.WriteLine("-----------------------------------------------------------------------------------------------------------");

listaDeNome.RemoveAt(1);
foreach (var item in listaDeNome)
{
    Console.WriteLine(item);
}

Console.WriteLine("-----------------------------------------------------------------------------------------------------------");

// Solicita uma Posição no Primeiro Parâmetro, e depois uma Contagem.
// Quero remover A Partir da Posição 1, Remover 2 Elementos.
listaDeNome.RemoveRange(1, 2);
foreach (var item in listaDeNome)
{
    Console.WriteLine(item);
}

Console.WriteLine("-----------------------------------------------------------------------------------------------------------");

string nome = listaDeNome.Find(x => x == "Ana");
Console.WriteLine(nome);
