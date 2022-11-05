
int n = int.Parse(Console.ReadLine());

int[,] mat = new int[n, n];
int[] diagonal = new int[n];
int negativos = new int();

for (int i = 0; i < n; i++)
{
    string[] valores = Console.ReadLine().Split(" ");

    for (int j = 0; j < n; j++)
    {
        mat[i,j] = int.Parse(valores[j]);
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i == j)
        {
            diagonal[i] = mat[i,j];
        }

        if (mat[i, j] % 2 != 0)
        {
            negativos++;
        }
    }
}

Console.WriteLine("Resultado: ");
Console.WriteLine("Diagonal: ");
foreach (var item in diagonal)
{
    Console.Write(item + " ");
}
Console.WriteLine("Total de Números Negativos");
Console.WriteLine(negativos);