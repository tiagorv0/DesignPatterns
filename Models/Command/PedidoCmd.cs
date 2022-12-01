namespace DesignPatterns.Models.Command
{
    public class PedidoCmd
    {
        public PedidoCmd(string nomeDoCliente, double valor)
        {
            NomeDoCliente = nomeDoCliente;
            Valor = valor;
            Status = StatusDoPedido.Novo;
        }

        public string NomeDoCliente { get; set; }
        public double Valor { get; set; }
        public StatusDoPedido Status { get; set; }
        public DateTime DataFinalizacao { get; set; }

        public void Pagar()
        {
            Status = StatusDoPedido.Pago;
        }

        public void Finalizar()
        {
            Status = StatusDoPedido.Finalizado;
            DataFinalizacao = DateTime.Now;
        }
    }
}
