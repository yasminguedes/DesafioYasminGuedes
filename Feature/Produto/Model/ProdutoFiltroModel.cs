namespace ProjetoDesafio.Feature.Produto.Model
{
    public class ProdutoFiltroModel : ProdutoModel
    {
        public bool PesquisarPorNomeProduto { get; set; }
        public bool PesquisarPorMarca { get; set; }
        public bool PesquisarPorValidade { get; set; }
        public bool PesquisarPorCodigo { get; set; }
    }
}
