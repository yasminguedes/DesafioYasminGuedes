using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoDesafio.Feature.Administrador.Model;

namespace ProjetoDesafio.Feature.Administrador.View
{
    public partial class FrmAdministrador : Form
    {
        public FrmAdministrador()
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
            mskTelefone.Enabled = habilitarCampos;
            mskRg.Enabled = habilitarCampos;
            mskCpf.Enabled = habilitarCampos;
            txtUsuario.Enabled = habilitarCampos;
            mskSenha.Enabled = habilitarCampos;
            mskSenhaConfirmar.Enabled = habilitarCampos;
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            HabilitarOuDesabilitarCampos(true);
            txtNome.Focus();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            var administrador = new AdministradorModel();
            {
                //NomePessoa = txtNome.Text,
                //Sexo = cmbSexo.Text,
                //Endereco =
                //{
                //    Cep = txtCep.Text,
                //    Rua = txtRua.Text,
                //    Numero = txtNumero.Text,
                //    Complemento = txtComplemento.Text,
                //    Bairro = txtBairro.Text,
                //    Cidade = txtCidade.Text,
                //    Estado = cmbEstado.Text,
                //    Pais = txtPais.Text
                //},
                //EmailPessoa = txtEmail.Text,
                //DataNascimento = DateTime.Parse(dtNascimento.Text),
                //TelefonePessoa = mskTelefone.Text,
                //RgIe = mskRg.Text,
                //CpfCnpj = mskCpf.Text,
                //UsuarioFuncionario = txtUsuario.Text,
                //SenhaFuncionario = mskSenha.Text,
                //ConfirmarSenha = mskSenhaConfirmar.Text
            };
            if (administrador.SenhasIguais)
                MessageBox.Show(@"Senhas não conferem");
        }
    }
}
