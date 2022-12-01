namespace DesignPatterns.Models.Strategy_E_Chain_Of_Responsibility.ComOPadrao
{
    public class EnviaMensagemComOPadrao
    {
        public void Enviar(List<Mensagem> mensagens, string tipo)
        {
            var enviaMensagemEmail = new EnviaMensagemEmail();
            var enviaMensagemSms = new EnviaMensagemSms();
            var enviaMensagemPush = new EnviaMensagemPush();
            var enviaMensagemSemCanal = new EnviaMensagemSemCAnal();
            enviaMensagemEmail.ProximoEnvio = enviaMensagemSms;
            enviaMensagemSms.ProximoEnvio = enviaMensagemPush;
            enviaMensagemPush.ProximoEnvio = enviaMensagemSemCanal;

            var enviaMensagem = enviaMensagemEmail.CriarEnvio(tipo);
            enviaMensagem.Enviar(mensagens);

        }
    }
}
