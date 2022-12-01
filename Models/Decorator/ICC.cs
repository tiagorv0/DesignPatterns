namespace DesignPatterns.Models.Decorator
{
    public class ICC : ImpostoDoProduto
    {
        protected override double ValorDoImposto => 0.05;

        public ICC()
        {
        }

        public ICC(ImpostoDoProduto outroImposto) : base(outroImposto)
        {
        }

        public override double Calcular(Produto produto)
        {
            return (produto.Valor * ValorDoImposto) + CalcularOutroImposto(produto);
        }
    }
}
