int m = new int();
int n = new int();

int[,] mat;

Console.WriteLine("Informe o valor de M: ");
m = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o valor de N: ");
n = int.Parse(Console.ReadLine());

mat = new int[m, n];

for (int i = 0; i < m; i++)
{
    string[] s = Console.ReadLine().Split(" ");

    for (int j = 0; j < n; j++)
    {
        mat[i, j] = int.Parse(s[n]);
    }
}

Console.Write("\nDentre os valores inteiros digitados, informe um: ");
m = int.Parse(Console.ReadLine());

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (j > 0)
        {
            Console.WriteLine("Lefht: " + mat[i, j - 1]);
        }

        if (i > 0)
        {
            Console.WriteLine("Down: " + mat[i - 1, j]);
        }

        if (mat[i, j - 1] > 0)
        {
            Console.WriteLine("Rigth: " + mat[i,j + 1]);
        }

        if (mat[i - 1, j] > 0)
        {
            Console.WriteLine("Top: " + mat[i + 1, j]);
        }
    }
}