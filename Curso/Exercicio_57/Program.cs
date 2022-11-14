
int n = new int();
int negativos = new int();
int[,] mat;

Console.Write("Informa um número inteiro: ");
n = int.Parse(Console.ReadLine());

mat = new int[n, n];

for (int i = 0; i < n; i++)
{
    string[] s = Console.ReadLine().Split(" ");

    for (int j = 0; j < n; j++)
    {
        mat[i,j] = int.Parse(s[j]);

        if (mat[i,j] < 0)
        {
            negativos++;
        }
    }
}

Console.WriteLine("\nNegatives numbers = " + negativos);
Console.Write("Main diagonal: ");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i == j)
        {
            Console.Write(mat[i,j] + " ");
        }
    }
}