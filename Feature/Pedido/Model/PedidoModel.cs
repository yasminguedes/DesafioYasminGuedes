using System;
using ProjetoDesafio.Feature.Categoria.Model;
using ProjetoDesafio.Feature.Cliente.Model;
using ProjetoDesafio.Feature.Marca.Model;
using ProjetoDesafio.Feature.Produto.Model;

namespace ProjetoDesafio.Feature.Pedido.Model
{
    public class PedidoModel
    {
        public int IdPedido { get; set; }
        public DateTime DataVenda { get; set; }
        public  double ValorItem { get; set; }
        public int QtdeVenda { get; set; }
        public string FormaPagamento { get; set; }
        public double TotalVenda { get; set; }
        public ClienteModel Cliente { get; set; }
        public ProdutoModel Produto { get; set; }
        public MarcaModel Marca { get; set; }
        public CategoriaModel Categoria { get; set; }
    }
}
