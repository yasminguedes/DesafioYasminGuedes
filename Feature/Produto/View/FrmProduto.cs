using System;
using System.Windows.Forms;
using ProjetoDesafio.Feature.Produto.Controller;
using ProjetoDesafio.Feature.Produto.Model;

namespace ProjetoDesafio.Feature.Produto.View
{
    public partial class FrmProduto : Form
    {
        private readonly ProdutoModel _produtoModel;
        private readonly ProdutoController _produtoController;

        public FrmProduto()
        {
            InitializeComponent();
            _produtoModel = new ProdutoModel();
            _produtoController = new ProdutoController();
            PreencherTipo();
            SelecionarAtivo();
            PreencherCategoria();
            PreencherMarca();
            PreencherFornecedor();
            HabilitarOuDesabilitarCampos(false);
            LimparCampos();
        }

        private void PreencherCategoria()
        {
            cmbCategoria.DataSource = _produtoController.ListarCategoria();
            cmbCategoria.DisplayMember = "NomeCategoria";
            cmbCategoria.ValueMember = "IdCategoria";
        }

        private void PreencherMarca()
        {
            cmbMarca.DataSource = _produtoController.ListarMarca();
            cmbMarca.DisplayMember = "NomeMarca";
            cmbMarca.ValueMember = "IdMarca";
        }

        private void PreencherFornecedor()
        {
            cmbFornecedor.DataSource = _produtoController.ListarFornecedor();
            cmbFornecedor.DisplayMember = "NomePessoa";
            cmbFornecedor.ValueMember = "IdFornecedor";
        }

        private void LimparCampos()
        {
            txtCompra.Text = string.Empty;
            txtNomeProduto.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
            txtVenda.Text = string.Empty;
            cmbAtivo.Text = string.Empty;
            cmbCategoria.Text = string.Empty;
            cmbMarca.Text = string.Empty;
            cmbTipo.Text = string.Empty;
            dtCadastro.Text = string.Empty;
            cmbFornecedor.Text = string.Empty;
            txtCodigo.Text = string.Empty;
            dtValidade.Text = string.Empty;
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
            txtCodigo.Enabled = habilitarCampos;
            dtValidade.Enabled = habilitarCampos;
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            HabilitarOuDesabilitarCampos(true);
            txtCodigo.Focus();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            _produtoModel.NomeProduto = txtNomeProduto.Text;
            _produtoModel.PrecoVenda = double.Parse(txtVenda.Text);
            _produtoModel.PrecoCompra = double.Parse(txtCompra.Text);
            _produtoModel.Tipo = cmbTipo.Text;
            _produtoModel.Ativo = cmbAtivo.Text;
            _produtoModel.Qtde = int.Parse(txtQuantidade.Text);
            _produtoModel.DataCadastro = DateTime.Parse(dtCadastro.Text);
            _produtoModel.DataValidade = DateTime.Parse(dtValidade.Text);
            _produtoModel.Codigo = int.Parse(txtCodigo.Text);
            _produtoModel.Marca.IdMarca = int.Parse(cmbMarca.SelectedValue.ToString());
            _produtoModel.Categoria.IdCategoria = int.Parse(cmbCategoria.SelectedValue.ToString());
            _produtoModel.Fornecedor.IdFornecedor = int.Parse(cmbFornecedor.SelectedValue.ToString());
            if (_produtoController.Cadastrar(_produtoModel))
                LimparCampos();
        }

        private void PreencherTipo()
        {
            cmbTipo.Items.Add(@"Caixa");
            cmbTipo.Items.Add(@"Fardo");
            cmbTipo.Items.Add(@"Litro");
            cmbTipo.Items.Add(@"Kg");
            cmbTipo.Items.Add(@"Unidade");
            cmbTipo.Items.Add(@"Engradado");
        }

        private void SelecionarAtivo()
        {
            cmbAtivo.Items.Add(@"Ativo");
            cmbAtivo.Items.Add(@"Inativo");
        }

        private void BtnCancelar_Click(object sender, EventArgs e) => Close();

        private void BtnListar_Click(object sender, EventArgs e) =>
            new FrmListagemDeProdutos().Show();

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNomeProduto.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Nome' é obrigatório.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtVenda.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Venda' é obrigatório.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCompra.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Compra' é obrigatório.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(cmbTipo.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Tipo' é obrigatório.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(cmbAtivo.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Ativo' é obrigatório.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtQuantidade.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Quantidade' é obrigatório.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(dtCadastro.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Cadastro' é obrigatório.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(cmbMarca.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Marca' é obrigatório.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(cmbCategoria.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Categoria' é obrigatório.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCodigo.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Código' é obrigatório.");
                return false;
            }
            if (!string.IsNullOrWhiteSpace(cmbFornecedor.Text.Trim())) return true;
            MessageBox.Show(@"Campo 'Fornecedor' é obrigatório.");
            return false;
        }
    }
}
