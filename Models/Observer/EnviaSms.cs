using DesignPatterns.Models.Observer.Interfaces;

namespace DesignPatterns.Models.Observer
{
    public class EnviaSms : IAcaoAposCadastroDePessoa
    {
        public void Executar(PessoaObs pessoa)
        {
            Console.WriteLine($"enviando sms para a pessoa: {pessoa.Nome}");
        }
    }
}
