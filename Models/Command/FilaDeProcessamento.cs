using DesignPatterns.Models.Command.Interfaces;

namespace DesignPatterns.Models.Command
{
    public class FilaDeProcessamento
    {
        private List<IComando> _comandos;

        public void Adicionar(IComando comando)
        {
            if(_comandos == null)
                _comandos= new List<IComando>();

            _comandos.Add(comando);
        }

        public void Processar()
        {
            _comandos.ForEach(x => x.Executar());
        }
    }
}
