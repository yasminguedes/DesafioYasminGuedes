namespace ProjetoDesafio.Feature.Funcionario.Model
{
    public class FuncionarioFiltroModel : FuncionarioModel
    {
        public bool PesquisarPorNome { get; set; }
        public bool PesquisarPorCargo { get; set; }
    }
}
