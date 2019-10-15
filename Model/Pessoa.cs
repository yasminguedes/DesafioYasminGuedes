using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDesafio.Model
{
    public class Pessoa 
    {
        public int idPessoa { get; set; }
        public string nomePessoa { get; set; }
        public string sexo { get; set; }
        public string rgIe { get; set; }
        public string cpfCnpj { get; set; }
        public string emailPessoa { get; set; }
        public string telefonePessoa { get; set; }
        public Endereco Endereco { get; set; }
    }
}
