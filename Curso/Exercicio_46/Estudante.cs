﻿namespace Exercicio_46
{
    internal class Estudante
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }

        public Estudante(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
    }
}
