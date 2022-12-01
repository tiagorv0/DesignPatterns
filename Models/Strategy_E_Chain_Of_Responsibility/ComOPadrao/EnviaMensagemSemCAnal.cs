using DesignPatterns.Models.Strategy_E_Chain_Of_Responsibility.ComOPadrao.Interfaces;

namespace DesignPatterns.Models.Strategy_E_Chain_Of_Responsibility.ComOPadrao
{
    public class EnviaMensagemSemCAnal : IEnviaMensagem
    {
        public IEnviaMensagem ProximoEnvio { get ; set ; }

        public IEnviaMensagem CriarEnvio(string tipo)
        {
            return this;
        }

        public void Enviar(List<Mensagem> mensagens)
        {
            Console.WriteLine("Envio não possui canal");
        }
    }
}
