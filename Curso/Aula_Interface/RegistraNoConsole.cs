namespace Aula_Interface
{
    internal class RegistraNoConsole : IRegistra
    {
        public void RegistraInfo(string mensagem)
        {
            Console.WriteLine("Mensagem no console");
        }
    }
}
