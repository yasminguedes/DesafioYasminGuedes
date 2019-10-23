using System;
using System.Windows.Forms;

namespace ProjetoDesafio.Feature.Categoria.View
{
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
            HabilitarOuDesabilitarCampos(false);
            LimparCampos();

        }
        private void LimparCampos()
        {
            txtCategoria.Text = "";
        }

        private void HabilitarOuDesabilitarCampos(bool habilitarCampos)
        {
            txtCategoria.Enabled = habilitarCampos;
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            HabilitarOuDesabilitarCampos(true);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Categoria cadastrada com sucesso!");
            LimparCampos();
        }
    }
}
