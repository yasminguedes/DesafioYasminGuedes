using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoDesafio.Feature.Pessoa.Model;

namespace ProjetoDesafio.Model
{
    public class Administrador: Pessoa
    {
        public int IdAdministrador { get; set; }
        public string UsuarioAdministrador { get; set; }
        public string SenhaAdministrador { get; set; }
    }
}
