using System;
using ProjetoDesafio.Feature.Funcionario.Controller;
using ProjetoDesafio.Feature.Funcionario.Model;
using System.Windows.Forms;

namespace ProjetoDesafio.Feature.Funcionario.View
{
    public partial class FrmFuncionario : Form
    {
        public FrmFuncionario()
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
            cmbCargo.Enabled = habilitarCampos;
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
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var funcionario = new FuncionarioModel
            {
                NomePessoa = txtNome.Text,
                Sexo = cmbSexo.Text,
                Endereco =
                {
                    Cep = txtCep.Text,
                    Rua = txtRua.Text,
                    Numero = txtNumero.Text,
                    Complemento = txtComplemento.Text,
                    Bairro = txtBairro.Text,
                    Cidade = txtCidade.Text,
                    Estado = cmbEstado.Text,
                    Pais = txtPais.Text
                },
                EmailPessoa = txtEmail.Text,
                DataNascimento = DateTime.Parse(dtNascimento.Text),
                Cargo =
                {
                    NomeCargo = cmbCargo.Text,
                },
                TelefonePessoa = mskTelefone.Text,
                RgIe = mskRg.Text,
                CpfCnpj = mskCpf.Text,
                UsuarioFuncionario = txtUsuario.Text,
                SenhaFuncionario = mskSenha.Text,
                ConfirmarSenha = mskSenhaConfirmar.Text
            };
            if (funcionario.SenhasIguais)
                MessageBox.Show(@"Senhas não conferem");

            new FuncionarioController().Cadastrar(funcionario);

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

