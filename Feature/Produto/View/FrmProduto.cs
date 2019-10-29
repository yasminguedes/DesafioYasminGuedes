using System;
using System.Windows.Forms;
using ProjetoDesafio.Feature.Produto.Controller;
using ProjetoDesafio.Feature.Produto.Model;

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
            PreencherCategoria();
            PreencherMarca();
            PreencherFornecedor();
            LimparCampos();
        }

        private void PreencherCategoria()
        {
            cmbCategoria.DataSource = new ProdutoController().ListarCategoria();
            cmbCategoria.DisplayMember = "NomeCategoria";
            cmbCategoria.ValueMember = "IdCategoria";
        }

        private void PreencherMarca()
        {
            cmbMarca.DataSource = new ProdutoController().ListarMarca();
            cmbMarca.DisplayMember = "NomeMarca";
            cmbMarca.ValueMember = "IdMarca";
        }

        private void PreencherFornecedor()
        {
            cmbFornecedor.DataSource = new ProdutoController().ListarFornecedor();
            cmbFornecedor.DisplayMember = "NomePessoa";
            cmbFornecedor.ValueMember = "IdFornecedor";
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
            txtNomeProduto.Focus();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
            {
            var produto = new ProdutoModel
            {
                NomeProduto = txtNomeProduto.Text,
                PrecoVenda = double.Parse(txtVenda.Text),
                PrecoCompra = double.Parse(txtCompra.Text),
                Tipo = cmbTipo.Text,
                Ativo = cmbAtivo.Text,
                Qtde = int.Parse(txtQuantidade.Text),
                DataCadastro = DateTime.Parse(dtCadastro.Text),
                Marca =
                {
                    IdMarca = int.Parse(cmbMarca.SelectedValue.ToString()),
                },
                Categoria =
                {
                    IdCategoria = int.Parse(cmbCategoria.SelectedValue.ToString()),
                },
                Fornecedor =
                {
                    IdFornecedor = int.Parse(cmbFornecedor.SelectedValue.ToString()),
                }
            };

            new ProdutoController().Cadastrar(produto);

            LimparCampos();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
