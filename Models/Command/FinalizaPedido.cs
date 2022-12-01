using DesignPatterns.Models.Command.Interfaces;

namespace DesignPatterns.Models.Command
{
    public class FinalizaPedido : IComando
    {
        private PedidoCmd _pedido;

        public FinalizaPedido(PedidoCmd pedido)
        {
            _pedido = pedido;
        }

        public void Executar()
        {
            _pedido.Finalizar();
            Console.WriteLine($"Pedido do cliente {_pedido.NomeDoCliente} foi finalizado!");
        }
    }
}
