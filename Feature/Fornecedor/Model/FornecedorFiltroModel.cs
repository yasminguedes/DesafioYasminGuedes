using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDesafio.Feature.Fornecedor.Model
{
    public class FornecedorFiltroModel:FornecedorModel
    {
        public bool PesquisarPorNomeFantasia { get; set; }
        public bool PesquisarPorRazaoSocial { get; set; }
    }
}
