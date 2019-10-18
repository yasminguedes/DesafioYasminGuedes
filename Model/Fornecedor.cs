using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoDesafio.Feature.Pessoa.Model;

namespace ProjetoDesafio.Model
{
   public class Fornecedor: PessoaModel
    {
        public int IdFornecedor { get; set; }
        public string RazaoSocial { get; set; }
        public string Representante { get; set; }
        public string CelularRepresentante { get; set; }
        public string EmailRepresentante { get; set; }
   }
}
