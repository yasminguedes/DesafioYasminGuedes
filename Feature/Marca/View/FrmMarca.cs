using System;
using System.Windows.Forms;

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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Marca cadastrada com sucesso!");
            LimparCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
