using DesignPatterns.Models.Observer.Interfaces;

namespace DesignPatterns.Models.Observer
{
    public class PessoaBuilderObs
    {
        public PessoaObs Construir()
        {
            return new PessoaObs(_nome, _dataNascimento, _cpf, _rg, _sexo, _apelido, _celular, _telefone, _email, _acoesAposCadastroDePessoa);
        }


        private string _nome;

        public PessoaBuilderObs SetNome(string nome)
        {
            _nome = nome;
            return this;
        }

        private DateTime _dataNascimento;

        public PessoaBuilderObs SetDataNascimento(DateTime dataNascimento)
        {
            _dataNascimento = dataNascimento;
            return this;
        }

        private string _cpf;

        public PessoaBuilderObs SetCpf(string cpf)
        {
            _cpf = cpf;
            return this;
        }

        private string _rg;

        public PessoaBuilderObs SetRg(string rg)
        {
            _rg = rg;
            return this;
        }

        private string _sexo;

        public PessoaBuilderObs SetSexo(string sexo)
        {
            _sexo = sexo;
            return this;
        }

        private string _apelido;

        public PessoaBuilderObs SetApelido(string apelido)
        {
            _apelido = apelido;
            return this;
        }

        private string _celular;

        public PessoaBuilderObs SetCelular(string celular)
        {
            _celular = celular;
            return this;
        }

        private string _telefone;

        public PessoaBuilderObs SetTelefone(string telefone)
        {
            _telefone = telefone;
            return this;
        }

        private string _email;

        public PessoaBuilderObs SetEmail(string email)
        {
            _email = email;
            return this;
        }

        private List<IAcaoAposCadastroDePessoa> _acoesAposCadastroDePessoa;

        public PessoaBuilderObs SetAcoesAposCadastroDePessoa(IAcaoAposCadastroDePessoa acaoAposCadastroDePessoa)
        {
            if (_acoesAposCadastroDePessoa == null)
                _acoesAposCadastroDePessoa = new List<IAcaoAposCadastroDePessoa>();

            _acoesAposCadastroDePessoa.Add(acaoAposCadastroDePessoa);
            return this;
        }
    }
}
