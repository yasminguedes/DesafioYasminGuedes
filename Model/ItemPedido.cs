using ProjetoDesafio.Feature.Categoria.Model;
using ProjetoDesafio.Feature.Marca.Model;
using ProjetoDesafio.Feature.Produto.Model;

namespace ProjetoDesafio.Model
{
    public class ItemPedido
    {
        public int IdItemPedido { get; set; }
        public double ValorItem { get; set; }
        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }
        public MarcaModel Marca { get; set; }
        public CategoriaModel Categoria { get; set; }
    }
}
