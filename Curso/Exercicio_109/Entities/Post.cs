using System.Text;

namespace Exercicio_109.Entities
{
    internal class Post
    {
        public DateTime Moment { get; private set; }
        public string Title { get; private set; }
        public string Content { get; private set; }
        public int Likes { get; private set; }

        public List<Comment> Comments = new List<Comment>();

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }
        public void AddComment (Comment comment)
        {
            Comments.Add(comment);
        }
        public void RemoveComment (Comment comment)
        {
            Comments.Remove(comment);
        }
        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine($"\n{Title}");
            sb.AppendLine($"{Likes} - {Moment.ToString()}");
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
