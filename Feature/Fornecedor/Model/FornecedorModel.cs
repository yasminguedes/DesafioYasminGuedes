using ProjetoDesafio.Feature.Pessoa.Model;

namespace ProjetoDesafio.Feature.Fornecedor.Model
{
   public class FornecedorModel: PessoaModel
    {
        public int IdFornecedor { get; set; }
        public string RazaoSocial { get; set; }
        public string Representante { get; set; }
        public string CelularRepresentante { get; set; }
        public string EmailRepresentante { get; set; }
   }
}
