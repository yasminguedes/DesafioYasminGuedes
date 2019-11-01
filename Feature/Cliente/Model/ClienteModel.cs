using System;
using ProjetoDesafio.Feature.Pessoa.Model;

namespace ProjetoDesafio.Feature.Cliente.Model
{
    public class ClienteModel : PessoaModel
    {
        public int IdCliente { get; set; }
        public string ProfissaoCliente { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
