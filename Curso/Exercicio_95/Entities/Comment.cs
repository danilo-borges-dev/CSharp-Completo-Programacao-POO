﻿namespace Exercicio_95.Entities
{
    internal class Comment
    {
        public string Text { get; private set; }
        public Comment(string text)
        {
            Text = text;
        }
    }
}
