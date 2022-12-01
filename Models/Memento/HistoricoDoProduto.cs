namespace DesignPatterns.Models.Memento
{
    public class HistoricoDoProduto
    {
        private IList<ProdutoMem> _produtos = new List<ProdutoMem>();

        public void Adicionar(ProdutoMem produto)
        {
            _produtos.Add(new ProdutoMem(produto.Nome, produto.Preco, produto.DataAlteracao));
        }

        public ProdutoMem Buscar(int index)
        {
            return _produtos[index];
        }
    }
}
