namespace DesignPatterns.Models.Strategy_E_Chain_Of_Responsibility.ComOPadrao.Interfaces
{
    public interface IEnviaMensagem
    {
        void Enviar(List<Mensagem> mensagens);
        IEnviaMensagem CriarEnvio(string tipo);
        IEnviaMensagem ProximoEnvio { get; set; }
    }
}
