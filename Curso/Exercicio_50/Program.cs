
int n = new int();
int[,] mat;
int cont = new int();

Console.Write("Informe o valor de N: ");
n = int.Parse(Console.ReadLine());
mat = new int[n, n];

for (int i = 0; i < n; i++)
{
    string[] valores = Console.ReadLine().Split(" ");

    for (int j = 0; j < n; j++)
    {
        mat[i,j] = int.Parse(valores[j]);

        if (mat[i, j] % 2 != 0)
        {
            cont++;
        }
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i == j)
        {
            Console.Write($"\nDiagonal: {mat[i,j]}");
        }
    }
}

Console.WriteLine("\nTotal de números negativos: " + cont);
