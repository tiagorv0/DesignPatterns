using DesignPatterns.Models.State;
using DesignPatterns.Models.State.Interface;

namespace ProjetoState.Models.State
{
    public class PedidoEmAndamento : IEstadoDoPedido
    {
        public void Aprovado(Pedido pedido)
        {
            pedido.EstadoAtual = new PedidoAprovado();
        }

        public void EmAndamento(Pedido pedido)
        {
            return;
        }

        public void Finalizado(Pedido pedido)
        {
            throw new Exception("Pedido em andamento não pode ser finalizado");
        }

        public void Reprovado(Pedido pedido)
        {
            pedido.EstadoAtual = new PedidoReprovado();
        }
    }
}
