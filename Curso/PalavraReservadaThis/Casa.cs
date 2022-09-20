using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalavraReservadaThis
{
    internal class Casa
    {
        public int Numero { get; set; }
        public int NQuartos { get; set; }
        public string Cor { get; set; }

        public Casa() { }
        public Casa(int numero, string cor)
        {
            Numero = numero;
            Cor = cor;
        }

        public Casa(int numero, string cor, int nQuartos) : this (numero, cor)
        {
            NQuartos = nQuartos;
        }
    }
}
