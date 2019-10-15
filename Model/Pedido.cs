using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDesafio.Model
{
    public class Pedido
    {
        public int idPedido { get; set; }
        public DateTime dataVenda { get; set; }
        public int qtdeVenda { get; set; }
        public string formaPagamento { get; set; }
        public double totalVenda { get; set; }
        public Cliente Cliente { get; set; }
    }
}
