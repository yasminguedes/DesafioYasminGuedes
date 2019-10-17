using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoDesafio.Feature.Produto.Model;

namespace ProjetoDesafio.Model
{
    public class PromocaoProduto
    {
        public int IdPromoProduto { get; set; }
        public string ItemPromo { get; set; }
        public Promocao Promocao { get; set; }
        public Produto Produto { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }

    }
}
