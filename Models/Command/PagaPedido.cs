using DesignPatterns.Models.Command.Interfaces;

namespace DesignPatterns.Models.Command
{
    public class PagaPedido : IComando
    {
        private PedidoCmd _pedido;

        public PagaPedido(PedidoCmd pedido)
        {
            _pedido = pedido;
        }

        public void Executar()
        {
            _pedido.Pagar();
            Console.WriteLine($"Pedido do cliente {_pedido.NomeDoCliente} foi pago!");
        }
    }
}
