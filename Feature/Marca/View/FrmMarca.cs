using System;
using System.Windows.Forms;
using ProjetoDesafio.Feature.Marca.Controller;
using ProjetoDesafio.Feature.Marca.Model;

namespace ProjetoDesafio.Feature.Marca.View
{
    public partial class FrmMarca : Form
    {
        public FrmMarca()
        {
            InitializeComponent();
            HabilitarOuDesabilitarCampos(false);
            LimparCampos();
        }
        private void LimparCampos()
        {
            txtMarca.Text = "";
        }

        private void HabilitarOuDesabilitarCampos(bool habilitarCampos)
        {
            txtMarca.Enabled = habilitarCampos;
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            HabilitarOuDesabilitarCampos(true);
            txtMarca.Focus();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            var marca = new MarcaModel()
            {
                NomeMarca = txtMarca.Text
            };
            new MarcaController().Cadastrar(marca);
            LimparCampos();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
