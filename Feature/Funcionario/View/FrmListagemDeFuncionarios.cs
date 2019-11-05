using System;
using System.Windows.Forms;
using ProjetoDesafio.Feature.Funcionario.Controller;
using ProjetoDesafio.Feature.Funcionario.Model;

namespace ProjetoDesafio.Feature.Funcionario.View
{
    public partial class FrmListagemDeFuncionarios : Form
    {
        private readonly FuncionarioController _funcionarioController;
        public FrmListagemDeFuncionarios()
        {
            InitializeComponent();
            _funcionarioController = new FuncionarioController();
            ListarFuncionarios();
        }

        private void ListarFuncionarios()
        {
            var filtro = Filtrar();
            dtListaFuncionarios.DataSource = _funcionarioController.Listar(filtro);
        }

        private FuncionarioFiltroModel Filtrar() =>
                new FuncionarioFiltroModel
                {
                    NomePessoa = txtPesquisar.Text,
                    Cargo = {NomeCargo = txtPesquisar.Text},
                    UsuarioFuncionario = txtPesquisar.Text,
                    PesquisarPorCargo = rdbCargo.Checked,
                    PesquisarPorNome = rdbNome.Checked
                };
        private void DtListagemDeFuncionarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) =>
            e.Value = Propriedades.BuscaPropriedadesComPonto(dtListaFuncionarios, e);

        private void BtnPesquisar_Click(object sender, EventArgs e) => ListarFuncionarios();

        private void TxtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ListarFuncionarios();
        }
    }
}
