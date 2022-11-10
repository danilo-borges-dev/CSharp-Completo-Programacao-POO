using Revisando_Arrays_2.Models;

int[] i = new int[2]
{
    2, 3
};

Atletas[] listaAtletas = new Atletas[5];

listaAtletas[0] = new Atletas(10, 50.0, "João Paulo");
listaAtletas[1] = new Atletas(1, 50.0, "Marcos Silva");
listaAtletas[2] = new Atletas(5, 50.0, "Rosana Pereira");
listaAtletas[3] = new Atletas(8, 50.0, "Natália Garcia");
listaAtletas[4] = new Atletas(9, 50.0, "Roberto Caramelo");

Array.Sort(listaAtletas);

foreach (var item in listaAtletas)
{
    Console.WriteLine(item.Id);
    Console.WriteLine(item.Nome);
}