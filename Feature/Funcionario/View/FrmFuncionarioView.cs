using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDesafio.Feature.Funcionario.View
{
    public partial class FrmFuncionarioView : Form
    {
        public FrmFuncionarioView()
        {
            InitializeComponent();

            txtNome.Enabled = false;
            txtRua.Enabled = false;
            txtNumero.Enabled = false;
            txtCep.Enabled = false;
            txtComplemento.Enabled = false;
            txtCidade.Enabled = false;
            cmbEstado.Enabled = false;
            txtPais.Enabled = false;
            dtNascimento.Enabled = false;
            cmbSexo.Enabled = false;
            txtEmail.Enabled = false;
            cmbCargo.Enabled = false;
            mskTelefone.Enabled = false;
            mskRg.Enabled = false;
            mskCpf.Enabled = false;
            txtUsuario.Enabled = false;
            mskSenha.Enabled = false;
        }
        
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            txtRua.Enabled = true;
            txtNumero.Enabled = true;
            txtCep.Enabled = true;
            txtComplemento.Enabled = true;
            txtCidade.Enabled = true;
            cmbEstado.Enabled = true;
            txtPais.Enabled = true;
            dtNascimento.Enabled = true;
            cmbSexo.Enabled = true;
            txtEmail.Enabled = true;
            cmbCargo.Enabled = true;
            mskTelefone.Enabled = true;
            mskRg.Enabled = true;
            mskCpf.Enabled = true;
            txtUsuario.Enabled = true;
            mskSenha.Enabled = true;

        }


      private void BtnListar_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
