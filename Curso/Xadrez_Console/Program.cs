using Xadrez_Console;
using Xadrez_Console.Tabuleiros;
using Xadrez_Console.Tabuleiros.Enums;
using Xadrez_Console.Xadrez;


//PosicaoXadrez pos = new('a', 1);
//Console.WriteLine(pos);

//Console.WriteLine(pos.ToPosicao());

try
{
    Tabuleiro tab = new(8, 8);

    tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 0));
    tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(1, 3));
    tab.ColocarPeca(new Rei(Cor.Preta, tab), new Posicao(1, 5));

    tab.ColocarPeca(new Torre(Cor.Branca, tab), new Posicao(3, 5));

    Tela.ImprimirTabuleiro(tab);
}
catch (TabuleiroException ex)
{
    Console.WriteLine(ex.Message);
}

