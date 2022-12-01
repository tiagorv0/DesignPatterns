namespace DesignPatterns.Models.Memento
{
    public class ProdutoMem
    {
        public ProdutoMem(string nome, double preco, DateTime dataAlteracao)
        {
            Nome = nome;
            Preco = preco;
            DataAlteracao = dataAlteracao;
        }

        public string Nome { get; set; }
        public double Preco { get; set; }
        public DateTime DataAlteracao { get; set; }

        public void EditarPreco(double preco)
        {
            Preco = preco;
            DataAlteracao= DateTime.Now;
        }
    }
}
