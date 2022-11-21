using Exercicio_73.Models.Exceptions;

namespace Exercicio_73.Models
{
    internal class Reserva
    {
        public int NumeroQuarto { get; private set; } = new int();
        public DateTime CheckIn { get; private set; } = new DateTime();
        public DateTime CheckOut { get; private set; } = new DateTime();

        public Reserva(int numeroQuarto, DateTime checkIn, DateTime checkOut)
        {
            NumeroQuarto = numeroQuarto;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duracao() 
        {
            TimeSpan duracao = CheckOut.Subtract(CheckIn);
            return (int)duracao.TotalDays;
        }

        public void AtualizarDatas(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;

            if (checkOut > checkIn)
            {
                throw new InvalidDataException("Erro: A data de Chck-out não pode ser Superior a data de Check-in.");
            }

            if (now < checkIn || now < checkOut)
            {
                throw new InvalidDataException("Erro: ");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }
    }
}
