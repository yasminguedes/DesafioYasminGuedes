using ProjetoDesafio.Feature.Marca.Controller;
using ProjetoDesafio.Feature.Marca.Model;
using System;
using System.Windows.Forms;
using ProjetoDesafio.Feature.Cliente.View;

namespace ProjetoDesafio.Feature.Marca.View
{
    public partial class FrmMarca : Form
    {
        private readonly MarcaModel _marcaModel;
        private readonly MarcaController _marcaController;

        public FrmMarca()
        {
            InitializeComponent();
            HabilitarOuDesabilitarCampos(false);
            LimparCampos();
            _marcaModel = new MarcaModel();
            _marcaController = new MarcaController();
        }

        private void LimparCampos() =>
            txtMarca.Text = string.Empty;

        private void HabilitarOuDesabilitarCampos(bool habilitarCampos)        {
            txtMarca.Enabled = habilitarCampos;
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            HabilitarOuDesabilitarCampos(true);
            txtMarca.Focus();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMarca.Text.Trim())) return;
            _marcaModel.NomeMarca = txtMarca.Text;
            if (_marcaController.Cadastrar(_marcaModel))
                LimparCampos();
        }

        private void BtnCancelar_Click(object sender, EventArgs e) => Close();

        private void BtnListar_Click(object sender, EventArgs e) =>
            new FrmListagemDeMarca().Show();

    }
}
