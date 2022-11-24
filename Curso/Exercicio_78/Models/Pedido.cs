using Exercicio_78.Models.Enums;
using System.Globalization;
using System.Text;

namespace Exercicio_78.Models
{
    internal class Pedido
    {
        public DateTime MomentoPedido { get; private set; } = new DateTime();
        public StatusPedido Status { get; private set; } = new StatusPedido();
        public Cliente Cliente { get; private set; }

        public List<PedidoItem> listaDePedidos = new List<PedidoItem>();

        public Pedido(DateTime momentoPedido, StatusPedido status, Cliente cliente)
        {
            MomentoPedido = momentoPedido;
            Status = status;
            Cliente = cliente;
        }

        public void AddPedidoItem(PedidoItem pedidoItem)
        {
            listaDePedidos.Add(pedidoItem);
        }

        public void RemovePedidoItem(PedidoItem pedidoItem)
        {
            listaDePedidos.Remove(pedidoItem);
        }

        public double ValorTotalPedido()
        {
            double total = new double();
            foreach (PedidoItem pedido in listaDePedidos)
            {
                total += pedido.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Data do pedido: {MomentoPedido.ToString()}");
            sb.AppendLine($"Status do pedido: {Status}");
            sb.AppendLine($"Cliente: {Cliente.Nome} - {Cliente.Email}");
            sb.AppendLine("Itens do Pedido: ");
            foreach (PedidoItem pedido in listaDePedidos)
            {
                sb.AppendLine($"{pedido.Produto.Nome}, Quantidade: {pedido.Quantidade}, Subtotal: $ {pedido.SubTotal().ToString("F2", CultureInfo.InvariantCulture)}");
            }
            sb.AppendLine($"Valor Total $ {ValorTotalPedido().ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}
