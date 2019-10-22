using ProjetoDesafio.Feature.Pessoa.Model;

namespace ProjetoDesafio.Feature.Administrador.Model
{
    public class AdministradorModel: PessoaModel
    {
        public int IdAdministrador { get; set; }
        public string UsuarioAdministrador { get; set; }
        public string SenhaAdministrador { get; set; }
        public string ConfirmarSenha { get; set; }

        public bool SenhasIguais =>
            SenhaAdministrador.Equals(ConfirmarSenha);
    }
}
