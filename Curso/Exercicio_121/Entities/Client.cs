namespace Exercicio_121.Entities
{
    internal sealed class Client
    {
        public string Name { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
        public DateTime BrithDate { get; private set; } = new DateTime();
        public Client(string name, string email, DateTime brithDate)
        {
            Name = name;
            Email = email;
            BrithDate = brithDate;
        }
    }
}
