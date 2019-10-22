using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoDesafio.Feature.Cliente.Model;

namespace ProjetoDesafio.Model
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public DateTime DataVenda { get; set; }
        public int QtdeVenda { get; set; }
        public string FormaPagamento { get; set; }
        public double TotalVenda { get; set; }
        public ClienteModel Cliente { get; set; }
    }
}
