Console.WriteLine("Digite três números: ");
int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());

int maior = new int();

if (n1 > n2 && n1 > n3)
{
    maior = n1;
}
else if (n2 > n3)
{
    maior = n2;
}
else
{
    maior = n3;
}

Console.WriteLine($"Mair número digitado: {maior}");