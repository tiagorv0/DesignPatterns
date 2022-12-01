namespace DesignPatterns.Models.Strategy_E_Chain_Of_Responsibility
{
    public class Mensagem
    {
        public Mensagem(string destino, string texto)
        {
            Destino = destino;
            Texto = texto;
        }

        public string Destino { get; private set; }
        public string Texto { get; private set; }
    }
}
