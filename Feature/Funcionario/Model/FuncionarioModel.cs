using ProjetoDesafio.Feature.Cargo.Model;
using ProjetoDesafio.Feature.Pessoa.Model;


namespace ProjetoDesafio.Feature.Funcionario.Model
{
    public class FuncionarioModel : PessoaModel
    {
        public int IdFuncionario { get; set; }
        public string UsuarioFuncionario { get; set; }
        public string SenhaFuncionario { get; set; }
        public CargoModel Cargo { get; set; }

        public FuncionarioModel()
        {
            Cargo = new CargoModel();
        }
    }
}
