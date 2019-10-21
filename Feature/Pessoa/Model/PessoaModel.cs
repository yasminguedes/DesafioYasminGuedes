using System;
using System.Windows.Forms;
using ProjetoDesafio.Feature.Endereco.Model;
using ProjetoDesafio.Model;

namespace ProjetoDesafio.Feature.Pessoa.Model
{
    public class PessoaModel 
    {
        public int IdPessoa { get; set; }
        public string NomePessoa { get; set; }
        public string Sexo { get; set; }
        public string RgIe { get; set; }
        public string CpfCnpj { get; set; }
        public string EmailPessoa { get; set; }
        public string TelefonePessoa { get; set; }
        public DateTime DataNascimento { get; set; }
        public EnderecoModel Endereco { get; set; }

        public PessoaModel()
        {
            Endereco = new EnderecoModel();
        }
        
    }
}
