using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoDesafio.Feature.Pessoa.Model;

namespace ProjetoDesafio.Model
{
    public class Cliente: PessoaModel
    {
        public int IdCliente { get; set; }
        public string ProfissaoCliente { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
