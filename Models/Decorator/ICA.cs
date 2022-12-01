namespace DesignPatterns.Models.Decorator
{
    public class ICA : ImpostoDoProduto
    {
        protected override double ValorDoImposto => 0.15; 

        public ICA()
        {
        }

        public ICA(ImpostoDoProduto outroImposto) : base(outroImposto)
        {
        }

        public override double Calcular(Produto produto)
        {
            return (produto.Valor * ValorDoImposto) + CalcularOutroImposto(produto);
        }
    }
}
