using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalavraReservadaThis
{
    internal class Aguia
    {
        public string Apelido { get; set; }
        public double Peso { get; set; }
        public string Cor { get; set; }
        public string Raca { get; set; }
        public double Tamanho { get; set; }

        public Aguia() { }
        public Aguia(string apelido, double peso, string cor, string raca)
        {
            Apelido = apelido;
            Raca = raca;
        }
        public Aguia(string apelido, double peso, string cor, string raca, double tamanho) : this (apelido, peso, cor, raca)
        {
            Tamanho = tamanho;
        }
    }
}
