using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDesafio.Model
{
    public class PromocaoProduto
    {
        public int idPromoProduto { get; set; }
        public string itemPromo { get; set; }
        public Promocao Promocao { get; set; }
        public Produto Produto { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }

    }
}
