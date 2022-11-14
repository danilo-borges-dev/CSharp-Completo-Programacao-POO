using System.Text;

namespace Exercicio_54.Models
{
    internal class Post
    {
        public DateTime Moment { get; private set; } = new DateTime();
        public int Likes { get; private set; } = new int();
        public string Title { get; private set; } 
        public string Content { get; private set; }

        public List<Comment> Comments = new List<Comment>();

        public Post(DateTime moment, string title, int likes, string content)
        {
            Moment = moment;
            Title = title;
            Likes = likes;
            Content = content;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");

            foreach (Comment comment in Comments)
            {
                sb.AppendLine(comment.Text);
            }

            return sb.ToString();
        }
    }
}
