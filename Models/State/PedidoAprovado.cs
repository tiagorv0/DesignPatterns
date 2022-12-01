using DesignPatterns.Models.State;
using DesignPatterns.Models.State.Interface;

namespace ProjetoState.Models.State
{
    public class PedidoAprovado : IEstadoDoPedido
    {
        public void Aprovado(Pedido pedido)
        {
            throw new Exception("Pedido já está com estado de aprovação");
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
            throw new Exception("Pedido está em estado de aprovação e não pode ser reprovado");
        }
    }
}
