namespace Exercicio_54.Models
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
