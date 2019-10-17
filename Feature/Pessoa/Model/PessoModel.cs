using ProjetoDesafio.Model;

namespace ProjetoDesafio.Feature.Pessoa.Model
{
    public class PessoModel 
    {
        public int IdPessoa { get; set; }
        public string NomePessoa { get; set; }
        public string Sexo { get; set; }
        public string RgIe { get; set; }
        public string CpfCnpj { get; set; }
        public string EmailPessoa { get; set; }
        public string TelefonePessoa { get; set; }
        public object Endereco { get; set; }
    }
}
