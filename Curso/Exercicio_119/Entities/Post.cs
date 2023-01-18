using System.Text;

namespace Exercicio_119.Entities
{
    internal class Post
    {
        public DateTime Moment { get; private set; }
        public string Title { get; private set; }
        public string Content { get; private set; }
        public int Likes { get; private set; }

        private List<Comment> Comments = new List<Comment>();
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
            sb.AppendLine($"Moment: {Moment.ToString()}");
            sb.AppendLine($"Title {Title}");
            sb.AppendLine($"Content: {Content}");
            sb.AppendLine($"Likes: {Likes.ToString()}");
            foreach (var comment in Comments)
            {
                sb.AppendLine($"Comment:\n {comment.Text}");
            }
            sb.AppendLine("-------------------------------------");
            return sb.ToString();
        }
    }
}
