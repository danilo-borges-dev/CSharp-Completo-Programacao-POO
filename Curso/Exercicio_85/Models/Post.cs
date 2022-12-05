using System.Text;

namespace Exercicio_85.Models
{
    internal class Post
    {
        public DateTime Moment { get; private set; } = new DateTime();
        public int Likes { get; private set; } = new int();
        public string Title { get; private set; }
        public string Content { get; private set; }

        List<Comment> CommentList = new List<Comment>();

        public Post(DateTime moment, int likes, string title, string content)
        {
            Moment = moment;
            Likes = likes;
            Title = title;
            Content = content;
        }

        public void AddComment(Comment comment)
        {
            CommentList.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            CommentList.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.Append("\nMoment = ");
            sb.AppendLine(Moment.ToString());
            sb.Append("Title = ");
            sb.AppendLine(Title);
            sb.Append("Content = ");
            sb.AppendLine(Content);
            sb.Append("Likes = ");
            sb.AppendLine(Likes.ToString());
            sb.AppendLine("Comments: ");
            foreach (Comment comment in CommentList)
            {
                sb.AppendLine(comment.Text);
            }
            return sb.ToString();
        }
    }
}
