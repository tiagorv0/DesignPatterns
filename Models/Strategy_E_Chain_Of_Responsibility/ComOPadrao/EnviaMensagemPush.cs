using DesignPatterns.Models.Strategy_E_Chain_Of_Responsibility.ComOPadrao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.Strategy_E_Chain_Of_Responsibility.ComOPadrao
{
    public class EnviaMensagemPush : IEnviaMensagem
    {
        public IEnviaMensagem ProximoEnvio { get ; set ; }

        public IEnviaMensagem CriarEnvio(string tipo)
        {
            if (tipo != "push")
                return ProximoEnvio.CriarEnvio(tipo);

            return this;
        }

        public void Enviar(List<Mensagem> mensagens)
        {
            //tudo que é necessario para enviar um Push
            Console.WriteLine("Push enviado");
        }
    }
}
