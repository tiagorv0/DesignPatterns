using DesignPatterns.Models.State.Interface;
using ProjetoState.Models.State;

namespace DesignPatterns.Models.State
{
    public class Pedido
    {
        public Pedido(string descricao, double valorTotal)
        {
            Descricao = descricao;
            ValorTotal = valorTotal;
            EstadoAtual = new PedidoEmAndamento();
        }

        public string Descricao { get; private set; }
        public double ValorTotal { get; private set; }
        public IEstadoDoPedido EstadoAtual { private get; set; }

        public void EmAndamento()
        {
            EstadoAtual.EmAndamento(this);
            Console.WriteLine("Em Andamento");
        }

        public void Aprovado()
        {
            EstadoAtual.Aprovado(this);
            Console.WriteLine("Aprovado");
        }

        public void Reprovado()
        {
            EstadoAtual.Reprovado(this);
            Console.WriteLine("Reprovado");
        }

        public void Finalizado()
        {
            EstadoAtual.Finalizado(this);
            Console.WriteLine("Finalizado");
        }
    }
}
