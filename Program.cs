using DesignPatterns.Models.Builder;
using DesignPatterns.Models.Decorator;
using DesignPatterns.Models.State;
using DesignPatterns.Models.Observer;
using DesignPatterns.Models.Factory;
using DesignPatterns.Models.Memento;
using DesignPatterns.Models.Command;
using DesignPatterns.Models.Strategy_E_Chain_Of_Responsibility;
using DesignPatterns.Models.Strategy_E_Chain_Of_Responsibility.ComOPadrao;



TesteStratgyAndChain();



void TestState()
{
    var pedido = new Pedido("Camisa", 200);
    try
    {
        pedido.EmAndamento();
        pedido.Aprovado();
        pedido.Finalizado();

    }catch(Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

void TestDecorator()
{
    var produto = new Produto("Camisa", 300);
    var imposto = new ICC(new ICA());
    var valorDoImposto = imposto.Calcular(produto);
    Console.WriteLine(valorDoImposto);
}

void TestBuilder()
{
    var pessoa = new PessoaBuilder()
                .SetNome("Tiago")
                .SetApelido("Vazzo")
                .SetCpf("98480408948")
                .SetDataNascimento(Convert.ToDateTime("1991-01-01"))
                .SetEmail("tiago@email.com")
                .Construir();

    Console.WriteLine(pessoa);
}

void TestObserver()
{
    var pessoa = new PessoaBuilderObs()
                .SetNome("Tiago")
                .SetApelido("Vazzo")
                .SetCpf("98480408948")
                .SetDataNascimento(Convert.ToDateTime("1991-01-01"))
                .SetEmail("tiago@email.com")
                .SetAcoesAposCadastroDePessoa(new EnviaSms())
                .SetAcoesAposCadastroDePessoa(new EnviaEmail())
                .Construir();

    Console.WriteLine(pessoa);
    pessoa.SalvarPessoa();
}

void TesteFactory()
{
    var conection = new ConnectionFactory().GetDbConnection();
}

void TesteMemento()
{
    var historioDoProduto = new HistoricoDoProduto();
    var produto = new ProdutoMem("Porcenalato", 300, DateTime.Now);

    historioDoProduto.Adicionar(produto);

    produto.EditarPreco(20);
    historioDoProduto.Adicionar(produto);

    produto.EditarPreco(50);
    historioDoProduto.Adicionar(produto);

    produto.EditarPreco(10);
    historioDoProduto.Adicionar(produto);

    produto.EditarPreco(60);
    historioDoProduto.Adicionar(produto);

    var indexParaPesquisa = 2;
    var produtoHistorico = historioDoProduto.Buscar(indexParaPesquisa);
    Console.WriteLine(produtoHistorico.Nome);
    Console.WriteLine(produtoHistorico.Preco);
    Console.WriteLine(produtoHistorico.DataAlteracao);
}

void TesteCommand()
{
    var pedido1 = new PedidoCmd("Mauricio", 150);
    var pedido2 = new PedidoCmd("Maria", 250);

    var filaDeProcessamento = new FilaDeProcessamento();

    filaDeProcessamento.Adicionar(new PagaPedido(pedido1));
    filaDeProcessamento.Adicionar(new PagaPedido(pedido2));
    filaDeProcessamento.Adicionar(new FinalizaPedido(pedido1));

    filaDeProcessamento.Processar();
}

void TesteStratgyAndChain()
{
    var mensagens = new List<Mensagem>();
    mensagens.Add(new Mensagem("teste@teste.com", "Obrigado por se cadastrar"));
    mensagens.Add(new Mensagem("teste2@teste.com", "Obrigado por se cadastrar"));
    mensagens.Add(new Mensagem("teste3@teste.com", "Obrigado por se cadastrar"));
    var enviaMensagem = new EnviaMensagemComOPadrao();
    enviaMensagem.Enviar(mensagens, "email");
}
