using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDesafio.Model
{
    public class Produto
    {
        public int idProduto { get; set; }
        public string nomeProduto { get; set; }
        public double precoCompra { get; set; }
        public double precoVenda { get; set; }
        public int qtdeEstoque { get; set; }
        public string ativo { get; set; }
        public DateTime dataCadastro { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
    }
}
