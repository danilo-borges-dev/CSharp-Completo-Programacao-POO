
int m = new int();
int n = new int();
int[,] mat;
int numero = new int();

Console.Write("Valor de M: ");
m = int.Parse(Console.ReadLine());
Console.Write("Valor de N: ");
n = int.Parse(Console.ReadLine());
mat = new int[m,n];

Console.WriteLine("\nInforme os Valores: ");

for (int i = 0; i < m; i++)
{
    string[] valores = Console.ReadLine().Split(" ");

    for (int j = 0; j < n; j++)
    {
        mat[i,j] = int.Parse(valores[j]);
    }
}

Console.Write("\nInforme um número: ");
numero = int.Parse(Console.ReadLine());

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (mat[i,j] == numero)
        {
            Console.WriteLine($"Posicao {i},{j}:");
            if (j > 0)
            {
                Console.Write("\nLefht: " + mat[i, j - 1]);
            }

            if (i > 0)
            {
                Console.Write("\nTop: " + mat[i - 1, j]);
            }

            if (j < m - 1)
            {
                Console.Write("\nLefht: " + mat[i, j + 1]);
            }

            if (i < m - 1)
            {
                Console.Write("\nLefht: " + mat[i + 1,j]);
            }
        }       
    }
}