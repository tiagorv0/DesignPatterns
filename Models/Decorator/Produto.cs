namespace DesignPatterns.Models.Decorator
{
    public class Produto
    {
        public Produto(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public string Nome { get; private set; }
        public double Valor { get; private set; }
    }
}
