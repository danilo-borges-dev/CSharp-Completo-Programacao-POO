using Xadrez_Console.Tabuleiros.Enums;

namespace Xadrez_Console.Tabuleiros
{
    internal class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; } = new Cor();
        public int QtdMovimentos { get; protected set; } = new int();
        public Tabuleiro Tab { get; protected set; }

        public Peca(Posicao posicao, Cor cor, Tabuleiro tab)
        {
            Posicao = posicao;
            Cor = cor;
            QtdMovimentos = 0;
            Tab = tab;
        }
    }
}
