using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoDesafio.Feature.Produto.Model;

namespace ProjetoDesafio.Model
{
    public class ItemPedido
    {
        public int IdItemPedido { get; set; }
        public double ValorItem { get; set; }
        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
    }
}
