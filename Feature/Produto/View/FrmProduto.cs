using System;
using System.Windows.Forms;

namespace ProjetoDesafio.Feature.Produto.View
{
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
            HabilitarOuDesabilitarCampos(false);
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtCompra.Text = "";
            txtNomeProduto.Text = "";
            txtQuantidade.Text = "";
            txtVenda.Text = "";
            cmbAtivo.Text = "";
            cmbCategoria.Text = "";
            cmbMarca.Text = "";
            cmbTipo.Text = "";
            dtCadastro.Text = "";
        }
        private void HabilitarOuDesabilitarCampos(bool habilitarCampos)
        {
            txtNomeProduto.Enabled = habilitarCampos;
            txtCompra.Enabled = habilitarCampos;
            txtVenda.Enabled = habilitarCampos;
            txtQuantidade.Enabled = habilitarCampos;
            cmbMarca.Enabled = habilitarCampos;
            cmbCategoria.Enabled = habilitarCampos;
            cmbTipo.Enabled = habilitarCampos;
            cmbAtivo.Enabled = habilitarCampos;
            dtCadastro.Enabled = habilitarCampos;
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            HabilitarOuDesabilitarCampos(true);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Produto cadastrado com sucesso!");
            LimparCampos();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
