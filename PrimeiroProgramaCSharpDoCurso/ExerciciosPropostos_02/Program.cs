string condicao = " ";

do
{
    Console.WriteLine("Digite um número ou digite s para sair: ");
    condicao = Console.ReadLine();

    int num = new int();

    if (condicao == "s")
    {
        num = int.Parse(condicao);
    }
    else
    {
        if (num > 0)
        {
            Console.WriteLine("O número é positivo.");
        }
        else
        {
            Console.WriteLine("O número é negativo.");
        }
    }


} while (condicao.ToLower() != "s");