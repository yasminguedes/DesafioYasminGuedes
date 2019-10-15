using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDesafio.Model
{
    public class Administrador: Pessoa
    {
        public int idAdministrador { get; set; }
        public string usuarioAdministrador { get; set; }
        public string senhaAdministrador { get; set; }
    }
}
