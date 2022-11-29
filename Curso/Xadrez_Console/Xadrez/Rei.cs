using Xadrez_Console.Tabuleiros;
using Xadrez_Console.Tabuleiros.Enums;

namespace Xadrez_Console.Xadrez
{
    internal class Rei : Peca
    {
        public Rei(Cor cor, Tabuleiro tab) : base(cor, tab)
        {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}
