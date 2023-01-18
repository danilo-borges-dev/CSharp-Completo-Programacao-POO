namespace Exercicio_119.Entities
{
    internal sealed class Comment
    {
        public string Text { get; private set; }
        public Comment(string text)
        {
            Text = text;
        }
    }
}
