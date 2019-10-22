using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoDesafio.Feature.Fornecedor.Model;
using ProjetoDesafio.Feature.Pessoa.Model;

namespace ProjetoDesafio.Feature.Fornecedor.Controller
{
    public class FornecedorController:PessoaModel
    {
        public bool Cadastrar(FornecedorModel fornecedor)
        {
            return true;
            
        }
    }
}
