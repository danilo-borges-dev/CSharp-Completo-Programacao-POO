using System.Text;

namespace Exercicio_95.Entities
{
    internal class Post
    {
        public DateTime Moment { get; private set; }
        public string Title { get; private set; }
        public string Contente { get; private set; }
        public int Likes { get; private set; }

        public List<Comment> CommentsList = new List<Comment>();
        public Post(DateTime moment, string title, string contente, int likes)
        {
            Moment = moment;
            Title = title;
            Contente = contente;
            Likes = likes;
        }
        public void AddComment(Comment comment)
        {
            CommentsList.Add(comment);
        }
        public void RemoveComment(Comment comment)
        {
            CommentsList.Remove(comment);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Momment: {Moment.ToString()}");
            sb.AppendLine($"Title: {Title}");
            sb.AppendLine($"Contet: {Contente}");
            sb.AppendLine("Comments: ");
            foreach (Comment comment in CommentsList)
            {
                sb.AppendLine(comment.Text);
            }
            sb.AppendLine($"Likes: {Likes.ToString()}");
            return sb.ToString();
        }
    }
}
