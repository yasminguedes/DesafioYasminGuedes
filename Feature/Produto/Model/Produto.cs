using System;
using ProjetoDesafio.Feature.Categoria.Model;
using ProjetoDesafio.Feature.Marca.Model;

namespace ProjetoDesafio.Feature.Produto.Model
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public double PrecoCompra { get; set; }
        public double PrecoVenda { get; set; }
        public int Qtde { get; set; }
        public  string Tipo { get; set; }
        public string Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
        public MarcaModel Marca { get; set; }
        public CategoriaModel Categoria { get; set; }
    }
}
