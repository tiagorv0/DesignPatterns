using DesignPatterns.Models.State;
using DesignPatterns.Models.State.Interface;

namespace ProjetoState.Models.State
{
    public class PedidoFinalizado : IEstadoDoPedido
    {
        public void Aprovado(Pedido pedido)
        {
            throw new Exception("Pedido já foi finalizado, não pode ter seu estado alterado");
        }

        public void EmAndamento(Pedido pedido)
        {
            throw new Exception("Pedido já foi finalizado, não pode ter seu estado alterado");
        }

        public void Finalizado(Pedido pedido)
        {
            throw new Exception("Pedido já foi finalizado");
        }

        public void Reprovado(Pedido pedido)
        {
            throw new Exception("Pedido já foi finalizado, não pode ter seu estado alterado");
        }
    }
}
