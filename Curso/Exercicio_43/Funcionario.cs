﻿namespace Exercicio_43
{
    internal class Funcionario
    {
        public readonly int Id;
        public string Nome { get; private set; }
        public double Salario { get; private set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentarSalario(double porcentagem)
        {
            Salario += (Salario * porcentagem / 100);
        }
    }
}
