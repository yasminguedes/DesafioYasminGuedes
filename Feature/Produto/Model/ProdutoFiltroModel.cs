using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDesafio.Feature.Produto.Model
{
    public class ProdutoFiltroModel : ProdutoModel
    {
        public bool PesquisarPorNomeProduto { get; set; }
        public bool PesquisarPorMarca { get; set; }
    }
}
