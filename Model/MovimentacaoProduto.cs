using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDesafio.Model
{
    public class MovimentacaoProduto
    {
        public int idMovimentacaoEstoque { get; set; }
        public DateTime dataMovimentacao { get; set; }
        public string tipoMovimentacao { get; set; }
        public int qtdeEntrada { get; set; }
        public int qtdeSaida { get; set; }
        public int qtdeEstoque { get; set; }
        public Produto Produto { get; set; }
    }
}
