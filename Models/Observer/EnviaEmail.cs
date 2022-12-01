using DesignPatterns.Models.Observer.Interfaces;

namespace DesignPatterns.Models.Observer
{
    public class EnviaEmail : IAcaoAposCadastroDePessoa
    {
        public void Executar(PessoaObs pessoa)
        {
            Console.WriteLine($"enviando email para a pessoa: {pessoa.Nome}");
        }
    }
}
