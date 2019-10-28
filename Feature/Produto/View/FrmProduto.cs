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
            SelecionarTipo();
            SelecionarAtivo();
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
            cmbFornecedor.Text = "";
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
            cmbFornecedor.Enabled = habilitarCampos;
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            HabilitarOuDesabilitarCampos(true);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Produto cadastrado com sucesso!");
            LimparCampos();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();

        }
       private void SelecionarTipo()
        {
            cmbTipo.Items.Add(@"Caixa");
            cmbTipo.Items.Add(@"Fardo");
            cmbTipo.Items.Add(@"Litro");
            cmbTipo.Items.Add(@"Kg");
            cmbTipo.Items.Add(@"Unidade");
        }
        private void SelecionarAtivo()
        {
            cmbAtivo.Items.Add(@"Ativo");
            cmbAtivo.Items.Add(@"Inativo");
        }
    }
}
