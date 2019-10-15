using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDesafio.Model
{
    public class Funcionario: Pessoa
    {
        public int idFuncionario { get; set; }
        public string usuarioFuncionario { get; set; }
        public string senhaFuncionario { get; set; }
        public Cargo Cargo { get; set; }
    }
}
