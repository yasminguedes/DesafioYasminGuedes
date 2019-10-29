using System;
using ProjetoDesafio.Feature.Produto.Model;

namespace ProjetoDesafio.Feature.Estoque.Model
{
    public class MovimentacaoProduto
    {
        public int IdMovimentacaoEstoque { get; set; }
        public DateTime DataMovimentacao { get; set; }
        public string TipoMovimentacao { get; set; }
        public int QtdeEntrada { get; set; }
        public int QtdeSaida { get; set; }
        public int QtdeEstoque { get; set; }
        public ProdutoModel Produto { get; set; }

        public MovimentacaoProduto()
        {
            Produto = new ProdutoModel();
        }
    }
}
