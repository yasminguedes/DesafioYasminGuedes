using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDesafio.Model
{
   public class Fornecedor: Pessoa
    {
        public int idFornecedor { get; set; }
        public string razaoSocial { get; set; }
        public string representante { get; set; }
        public string celularRepresentante { get; set; }
        public string emailRepresentante { get; set; }
   }
}
