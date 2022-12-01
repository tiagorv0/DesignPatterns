using DesignPatterns.Models.Strategy_E_Chain_Of_Responsibility.ComOPadrao.Interfaces;

namespace DesignPatterns.Models.Strategy_E_Chain_Of_Responsibility.ComOPadrao
{
    public class EnviaMensagemEmail : IEnviaMensagem
    {
        public IEnviaMensagem ProximoEnvio { get; set; }

        public IEnviaMensagem CriarEnvio(string tipo)
        {
            if (tipo != "email")
                return ProximoEnvio.CriarEnvio(tipo);

            return this;
        }

        public void Enviar(List<Mensagem> mensagens)
        {
            //tudo que é necessario para enviar um email
            Console.WriteLine("Email enviado");
        }
    }
}
