using DesignPatterns.Models.State;
using DesignPatterns.Models.State.Interface;

namespace ProjetoState.Models.State
{
    public class PedidoReprovado : IEstadoDoPedido
    {
        public void Aprovado(Pedido pedido)
        {
            throw new Exception("Pedido está em estado de reprovação e não pode ser aprovado");
        }

        public void EmAndamento(Pedido pedido)
        {
            pedido.EstadoAtual = new PedidoEmAndamento();
        }

        public void Finalizado(Pedido pedido)
        {
            pedido.EstadoAtual = new PedidoFinalizado();
        }

        public void Reprovado(Pedido pedido)
        {
            throw new Exception("Pedido já foi reprovado");
        }
    }
}
