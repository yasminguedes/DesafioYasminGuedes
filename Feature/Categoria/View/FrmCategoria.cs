using System;
using System.Windows.Forms;
using ProjetoDesafio.Feature.Categoria.Controller;
using ProjetoDesafio.Feature.Categoria.Model;

namespace ProjetoDesafio.Feature.Categoria.View
{
    public partial class FrmCategoria : Form
    {
        private readonly CategoriaModel _categoriaModel;
        private readonly CategoriaController _categoriaController;

        public FrmCategoria()
        {
            InitializeComponent();
            _categoriaController = new CategoriaController();
            _categoriaModel = new CategoriaModel();
            HabilitarOuDesabilitarCampos(false);
            LimparCampos();
        }

        private void LimparCampos() =>
            txtCategoria.Text = string.Empty;
        
        private void HabilitarOuDesabilitarCampos(bool habilitarCampos) =>
            txtCategoria.Enabled = habilitarCampos;
        
        private void BtnCadastrar_Click(object sender, EventArgs e) =>
            HabilitarOuDesabilitarCampos(true);
        
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategoria.Text.Trim())) return;

            _categoriaModel.NomeCategoria = txtCategoria.Text;

            if(_categoriaController.Cadastrar(_categoriaModel))
                LimparCampos();
        }

        private void BtnCancelar_Click(object sender, EventArgs e) => Close();

        private void BtnListar_Click(object sender, EventArgs e) => new FrmListagemDeCategoria().Show();

    }
}
