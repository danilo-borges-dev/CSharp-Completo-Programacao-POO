namespace Aula_Interface
{
    internal class RegistroOcorrencia
    {
        public void RegistraConsole(string mensagem)
        {
            Console.WriteLine(mensagem);
            Console.ReadKey();
        }
        public void RegistraNoDisco(string nomeArquivo, string mensagem)
        {
            using(StreamWriter arquivo = new(nomeArquivo))
            {
                arquivo.WriteLine(mensagem);
                arquivo.Close();
            }
        }
    }
}
