using ProjetoDesafio.Model;

namespace ProjetoDesafio.Feature.Funcionario.Model
{
    public class FuncionarioModel: Pessoa.Model.PessoaModel
    {
        public int IdFuncionario { get; set; }
        public string UsuarioFuncionario { get; set; }
        public string SenhaFuncionario { get; set; }
        public int Cargo { get; set; }
    }
}
