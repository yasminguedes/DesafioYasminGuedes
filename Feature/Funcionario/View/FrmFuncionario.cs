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
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtRua.Text = "";
            txtNumero.Text = "";
            txtCep.Text = "";
            txtComplemento.Text = "";
            txtBairro.Text = "";
            cmbCidade.Text = "";
            cmbEstado.Text = "";
            txtPais.Text = "";
            dtNascimento.Text = "";
            cmbSexo.Text = "";
            txtEmail.Text = "";
            cmbCargo.Text = "";
            mskTelefone.Text = "";
            mskRg.Text = "";
            mskCpf.Text = "";
            txtUsuario.Text = "";
            mskSenha.Text = "";
            mskSenhaConfirmar.Text = "";
        }


        private void HabilitarOuDesabilitarCampos(bool habilitarCampos)
        {
            txtNome.Enabled = habilitarCampos;
            txtRua.Enabled = habilitarCampos;
            txtNumero.Enabled = habilitarCampos;
            txtCep.Enabled = habilitarCampos;
            txtComplemento.Enabled = habilitarCampos;
            txtBairro.Enabled = habilitarCampos;
            cmbCidade.Enabled = habilitarCampos;
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
        private void BtnSalvar_Click(object sender, EventArgs e)
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
                    Cidade = cmbCidade.Text,
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

            };
            if (funcionario.SenhasIguais)
                MessageBox.Show(@"Senhas não conferem");

            new FuncionarioController().Cadastrar(funcionario);
            LimparCampos();

        }
        
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelecionarEstado();
        }

        private void SelecionarEstado()
        {
            cmbEstado.Text = @"Acre (AC)";
            cmbEstado.Text = @"Alagoas (AL)";
            cmbEstado.Text = @"Amapá (AP)";
            cmbEstado.Text = @"Amazonas (AM)";
            cmbEstado.Text = @"Bahia (BA)";
            cmbEstado.Text = @"Ceará (CE)";
            cmbEstado.Text = @"Distrito Federal (DF)";
            cmbEstado.Text = @"Espírito Santo (ES)";
            cmbEstado.Text = @"Goiás (GO)";
            cmbEstado.Text = @"Maranhão (MA)";
            cmbEstado.Text = @"Mato Grosso (MT)";
            cmbEstado.Text = @"Mato Grosso do Sul (MS)";
            cmbEstado.Text = @"Minas Gerais (MG)";
            cmbEstado.Text = @"Pará (PA)";
            cmbEstado.Text = @"Paraíba (PB)";
            cmbEstado.Text = @"Paraná (PR)";
            cmbEstado.Text = @"Pernambuco (PE)";
            cmbEstado.Text = @"Piauí (PI)";
            cmbEstado.Text = @"Rio de Janeiro (RJ)";
            cmbEstado.Text = @"Rio Grande do Sul (RS)";
            cmbEstado.Text = @"Rondônia (RO)";
            cmbEstado.Text = @"Roraima (RR)";
            cmbEstado.Text = @"Santa Catarina (SC)";
            cmbEstado.Text = @"São Paulo (SP)";
            cmbEstado.Text = @"Sergipe (SE)";
            cmbEstado.Text = @"Tocantins (TO)";
        }
    }
}

