using ProjetoState.Models;

namespace DesignPatterns.Models.State.Interface
{
    public interface IEstadoDoPedido
    {
        void EmAndamento(Pedido pedido);
        void Aprovado(Pedido pedido);
        void Reprovado(Pedido pedido);
        void Finalizado(Pedido pedido);
    }
}
