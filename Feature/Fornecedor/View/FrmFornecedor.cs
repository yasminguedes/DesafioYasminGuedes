using System;
using System.Windows.Forms;
using ProjetoDesafio.Feature.Fornecedor.Controller;
using ProjetoDesafio.Feature.Fornecedor.Model;

namespace ProjetoDesafio.Feature.Fornecedor.View
{
    public partial class FrmFornecedor : Form
    {
        public FrmFornecedor()
        {
            InitializeComponent();
            HabilitarOuDesabilitarCampos(false);
        }
        private void HabilitarOuDesabilitarCampos(bool habilitarCampos)
        {
            txtNome.Enabled = habilitarCampos;
            txtRua.Enabled = habilitarCampos;
            txtNumero.Enabled = habilitarCampos;
            txtCep.Enabled = habilitarCampos;
            txtComplemento.Enabled = habilitarCampos;
            txtBairro.Enabled = habilitarCampos;
            txtCidade.Enabled = habilitarCampos;
            cmbEstado.Enabled = habilitarCampos;
            txtPais.Enabled = habilitarCampos;
            txtRazaoSocial.Enabled = habilitarCampos;
            txtEmail.Enabled = habilitarCampos;
            mskTelefone.Enabled = habilitarCampos;
            mskIe.Enabled = habilitarCampos;
            mskCnpj.Enabled = habilitarCampos;
            txtRepresentante.Enabled = habilitarCampos;
            txtEmailRepresentante.Enabled = habilitarCampos;
            mskTelefoneRepresentante.Enabled = habilitarCampos;
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            HabilitarOuDesabilitarCampos(true);
            txtNome.Focus();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            var fornecedor = new FornecedorModel();
            {
                
            };
            new FornecedorController().Cadastrar(fornecedor);
        }
    }
}
