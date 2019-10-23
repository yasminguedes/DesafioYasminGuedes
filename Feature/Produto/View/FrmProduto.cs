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
            SelecionarMarca();
            SelecionarCategoria();
            SelecionarTipo();
            SelecionarFornecedor();
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
        private void SelecionarMarca()
        {
            cmbMarca.Items.Add(@"Coca-Cola");
            cmbMarca.Items.Add(@"Sprite");
            cmbMarca.Items.Add(@"Fanta");
            cmbMarca.Items.Add(@"Saboraki");
            cmbMarca.Items.Add("Guaraná Antartica");
            cmbMarca.Items.Add("Cotuba");
            cmbMarca.Items.Add(@"Skol");
            cmbMarca.Items.Add(@"Brahma");
            cmbMarca.Items.Add(@"Antartica");
            cmbMarca.Items.Add(@"Antartica Original");
            cmbMarca.Items.Add(@"Eisenbahn");
            cmbMarca.Items.Add(@"51");
            cmbMarca.Items.Add(@"Velho Barreiro");
            cmbMarca.Items.Add(@"José Cuervo");
            cmbMarca.Items.Add(@"Orloff");
            cmbMarca.Items.Add(@"Globo");
            cmbMarca.Items.Add(@"Siamar");
            cmbMarca.Items.Add(@"Sadia");
            cmbMarca.Items.Add(@"Perdigão");
            cmbMarca.Items.Add(@"Piracanjuba");
            cmbMarca.Items.Add(@"Marba");
            cmbMarca.Items.Add(@"Sem Marca");
        }

        private void SelecionarCategoria()
        {
            cmbCategoria.Items.Add(@"Destilados");
            cmbCategoria.Items.Add(@"Cervejas");
            cmbCategoria.Items.Add(@"Refrigerante");
            cmbCategoria.Items.Add(@"Farinhas");
            cmbCategoria.Items.Add(@"Embutidos");
            cmbCategoria.Items.Add(@"Defumados");
            cmbCategoria.Items.Add(@"Laticinios");
        }

        private void SelecionarTipo()
        {
            cmbTipo.Items.Add(@"Caixa");
            cmbTipo.Items.Add(@"Fardo");
            cmbTipo.Items.Add(@"Litro");
            cmbTipo.Items.Add(@"Kg");
            cmbTipo.Items.Add(@"Unidade");
        }

        private void SelecionarFornecedor()
        {
            cmbFornecedor.Items.Add(@"Femsa");
            cmbFornecedor.Items.Add(@"JMP");
            cmbFornecedor.Items.Add(@"Ambev");
            cmbFornecedor.Items.Add(@"Conti");
            cmbFornecedor.Items.Add(@"JBS");
        }

        private void SelecionarAtivo()
        {
            cmbAtivo.Items.Add(@"Ativo");
            cmbAtivo.Items.Add(@"Inativo");
        }
    }
}
