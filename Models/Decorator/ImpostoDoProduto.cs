namespace DesignPatterns.Models.Decorator
{
    public abstract class ImpostoDoProduto
    {
        protected abstract double ValorDoImposto { get; }

        private ImpostoDoProduto _outroImposto;

        protected ImpostoDoProduto(ImpostoDoProduto outroImposto)
        {
            _outroImposto = outroImposto;
        }

        protected ImpostoDoProduto()
        {
            _outroImposto = null;
        }

        public abstract double Calcular(Produto produto);

        protected double CalcularOutroImposto(Produto produto)
        {
            if (_outroImposto == null) return 0;

            return _outroImposto.Calcular(produto);
        }
    }
}
