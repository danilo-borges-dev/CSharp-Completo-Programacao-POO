string condicao = " ";

do
{
    int num = new int();
    Console.WriteLine("Digite um número ou digite s para sair: ");
    condicao = Console.ReadLine();


    if (condicao == "s")
    {
        return;
    }
    else
    {
        num = int.Parse(condicao);
        //if (num > 0)
        //{
        //    Console.WriteLine("O número é positivo.");
        //}
        //else
        //{
        //    Console.WriteLine("O número é negativo.");
        //}

        if (num % 2 == 0)
        {
            Console.WriteLine("O número é par.");
        }
        else
        {
            Console.WriteLine("O número é impar.");
        }
    }


} while (condicao.ToLower() != "s");