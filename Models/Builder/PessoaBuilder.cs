namespace DesignPatterns.Models.Builder
{
    public class PessoaBuilder
    {
        public Pessoa Construir()
        {
            return new Pessoa(_nome, _dataNascimento, _cpf, _rg, _sexo, _apelido, _celular, _telefone, _email);
        }


        private string _nome;

        public PessoaBuilder SetNome(string nome)
        {
            _nome = nome;
            return this;
        }

        private DateTime _dataNascimento;

        public PessoaBuilder SetDataNascimento(DateTime dataNascimento)
        {
            _dataNascimento = dataNascimento;
            return this;
        }

        private string _cpf;

        public PessoaBuilder SetCpf(string cpf)
        {
            _cpf = cpf;
            return this;
        }

        private string _rg;

        public PessoaBuilder SetRg(string rg)
        {
            _rg = rg;
            return this;
        }

        private string _sexo;

        public PessoaBuilder SetSexo(string sexo)
        {
            _sexo = sexo;
            return this;
        }

        private string _apelido;

        public PessoaBuilder SetApelido(string apelido)
        {
            _apelido = apelido;
            return this;
        }

        private string _celular;

        public PessoaBuilder SetCelular(string celular)
        {
            _celular = celular;
            return this;
        }

        private string _telefone;

        public PessoaBuilder SetTelefone(string telefone)
        {
            _telefone = telefone;
            return this;
        }

        private string _email;

        public PessoaBuilder SetEmail(string email)
        {
            _email = email;
            return this;
        }
    }
}
