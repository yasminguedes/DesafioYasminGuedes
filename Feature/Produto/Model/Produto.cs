using System;
using ProjetoDesafio.Model;

namespace ProjetoDesafio.Feature.Produto.Model
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public double PrecoCompra { get; set; }
        public double PrecoVenda { get; set; }
        public int QtdeEstoque { get; set; }
        public string Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
    }
}
