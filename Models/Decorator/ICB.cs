namespace DesignPatterns.Models.Decorator
{
    public class ICB : ImpostoDoProduto
    {
        protected override double ValorDoImposto => 0.10;

        public ICB()
        {
        }

        public ICB(ImpostoDoProduto outroImposto) : base(outroImposto)
        {
        }

        public override double Calcular(Produto produto)
        {
            return (produto.Valor * ValorDoImposto) + CalcularOutroImposto(produto);
        }
    }
}
