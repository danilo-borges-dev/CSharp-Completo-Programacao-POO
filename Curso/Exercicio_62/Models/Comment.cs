namespace Exercicio_62.Models
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
