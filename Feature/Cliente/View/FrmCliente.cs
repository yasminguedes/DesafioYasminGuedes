using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoDesafio.Feature.Cliente.Model;

namespace ProjetoDesafio.Feature.Cliente.View
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
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
            dtNascimento.Enabled = habilitarCampos;
            cmbSexo.Enabled = habilitarCampos;
            txtEmail.Enabled = habilitarCampos;
            txtProfissao.Enabled = habilitarCampos;
            mskTelefone.Enabled = habilitarCampos;
            mskRg.Enabled = habilitarCampos;
            mskCpf.Enabled = habilitarCampos;
            dtCadastro.Enabled = habilitarCampos;
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            HabilitarOuDesabilitarCampos(true);
            txtNome.Focus();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            var cliente = new ClienteModel();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
