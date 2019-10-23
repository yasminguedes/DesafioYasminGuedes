using ProjetoDesafio.Feature.Categoria.Model;
using ProjetoDesafio.Feature.Marca.Model;
using ProjetoDesafio.Feature.Produto.Model;
using ProjetoDesafio.Feature.Promocao.Model;

namespace ProjetoDesafio.Model
{
    public class PromocaoProduto
    {
        public int IdPromoProduto { get; set; }
        public string ItemPromo { get; set; }
        public PromocaoModel Promocao { get; set; }
        public Produto Produto { get; set; }
        public MarcaModel Marca { get; set; }
        public CategoriaModel Categoria { get; set; }

    }
}
