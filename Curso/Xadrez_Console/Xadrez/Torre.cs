using Xadrez_Console.Tabuleiros;
using Xadrez_Console.Tabuleiros.Enums;

namespace Xadrez_Console.Xadrez
{
    internal class Torre : Peca
    {
        public Torre(Cor cor, Tabuleiro tab) : base(cor, tab)
        {

        }

        public override string ToString()
        {
            return "T";
        }
    }
}
