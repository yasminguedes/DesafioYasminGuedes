using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoDesafio.Feature.Produto.Model;

namespace ProjetoDesafio.Model
{
    public class MovimentacaoProduto
    {
        public int IdMovimentacaoEstoque { get; set; }
        public DateTime DataMovimentacao { get; set; }
        public string TipoMovimentacao { get; set; }
        public int QtdeEntrada { get; set; }
        public int QtdeSaida { get; set; }
        public int QtdeEstoque { get; set; }
        public Produto Produto { get; set; }
    }
}
