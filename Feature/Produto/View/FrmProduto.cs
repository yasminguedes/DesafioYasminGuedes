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
            _produtoModel.NomeProduto = txtNomeProduto.Text;
            _produtoModel.PrecoVenda = double.Parse(txtVenda.Text);
            _produtoModel.PrecoCompra = double.Parse(txtCompra.Text);
            _produtoModel.Tipo = cmbTipo.Text;
            _produtoModel.Ativo = cmbAtivo.Text;
            _produtoModel.Qtde = int.Parse(txtQuantidade.Text);
            _produtoModel. DataCadastro = DateTime.Parse(dtCadastro.Text);
            _produtoModel.Marca.IdMarca = int.Parse(cmbMarca.SelectedValue.ToString());
            _produtoModel.Categoria.IdCategoria = int.Parse(cmbCategoria.SelectedValue.ToString());
            _produtoModel.Fornecedor.IdFornecedor = int.Parse(cmbFornecedor.SelectedValue.ToString());
          if(_produtoController.Cadastrar(_produtoModel))
            LimparCampos();
        }

        private void PreencherTipo()
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

        private void BtnCancelar_Click(object sender, EventArgs e) => Close();
        

        private void BtnListar_Click(object sender, EventArgs e) =>
            new FrmListagemDeProdutos().Show();
        
    }
}
