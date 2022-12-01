using DesignPatterns.Models.Observer.Interfaces;

namespace DesignPatterns.Models.Observer
{
    public class PessoaObs
    {
        public PessoaObs(string nome, DateTime dataNascimento, string cpf, 
            string rg, string sexo, string apelido, 
            string celular, string telefone, string email, 
            List<IAcaoAposCadastroDePessoa> acoesAposCadastro)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Cpf = cpf;
            Rg = rg;
            Sexo = sexo;
            Apelido = apelido;
            Celular = celular;
            Telefone = telefone;
            Email = email;
            _acoesAposCadastro = acoesAposCadastro;
        }

        public string Nome { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string Cpf { get; private set; }
        public string Rg { get; private set; }
        public string Sexo { get; private set; }
        public string Apelido { get; private set; }
        public string Celular { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }

        private List<IAcaoAposCadastroDePessoa> _acoesAposCadastro;

        public void SalvarPessoa()
        {
            Console.WriteLine("Pessoa Salva");
            foreach (var acao in _acoesAposCadastro)
                acao.Executar(this);
        }

        public override string ToString()
        {
            return @$"Nome: {Nome}
                      Data de Nascimento: {DataNascimento}
                      Cpf: {Cpf}
                      Rg: {Rg}
                      Sexo: {Sexo}
                      Apelido: {Apelido}
                      Celular: {Celular}
                      Email: {Email} ";
        }
    }
}
