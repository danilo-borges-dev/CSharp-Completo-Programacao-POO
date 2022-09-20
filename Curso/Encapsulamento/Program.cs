using Encapsulamento;

Produto p = new("Feijão", 10, 5.50);

try
{
    p.DefinirNome(" ");
}
catch (ArgumentNullException ex)
{
    Console.WriteLine("Está tentando definir um nome vazio ou que possua números.", ex.Message.ToString());
}

Console.WriteLine(p.GetNomeDeCliente());