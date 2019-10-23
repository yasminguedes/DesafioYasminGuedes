using System;
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
            SelecionarEstado();
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
            mskTelefone.Enabled = habilitarCampos;
            mskRg.Enabled = habilitarCampos;
            mskCpf.Enabled = habilitarCampos;
            txtUsuario.Enabled = habilitarCampos;
            mskSenha.Enabled = habilitarCampos;
            mskSenhaConfirmar.Enabled = habilitarCampos;
        }
        public void SelecionarEstado()
        {
            cmbEstado.Items.Add("Acre (AC)");
            cmbEstado.Items.Add("Alagoas (AL)");
            cmbEstado.Items.Add("Amapá (AP)");
            cmbEstado.Items.Add("Amazonas (AM)");
            cmbEstado.Items.Add("Bahia (BA)");
            cmbEstado.Items.Add("Ceará (CE)");
            cmbEstado.Items.Add("Distrito Federal (DF)");
            cmbEstado.Items.Add("Espírito Santo (ES)");
            cmbEstado.Items.Add("Goiás (GO)");
            cmbEstado.Items.Add("Maranhão (MA)");
            cmbEstado.Items.Add("Mato Grosso (MT)");
            cmbEstado.Items.Add("Mato Grosso do Sul (MS)");
            cmbEstado.Items.Add("Minas Gerais (MG)");
            cmbEstado.Items.Add("Pará (PA)");
            cmbEstado.Items.Add("Paraíba (PB)");
            cmbEstado.Items.Add("Paraná (PR)");
            cmbEstado.Items.Add("Pernambuco (PE)");
            cmbEstado.Items.Add("Piauí (PI)");
            cmbEstado.Items.Add("Rio de Janeiro (RJ)");
            cmbEstado.Items.Add("Rio Grande do Sul (RS)");
            cmbEstado.Items.Add("Rondônia (RO)");
            cmbEstado.Items.Add("Roraima (RR)");
            cmbEstado.Items.Add("Santa Catarina (SC)");
            cmbEstado.Items.Add("São Paulo (SP)");
            cmbEstado.Items.Add("Sergipe (SE)");
            cmbEstado.Items.Add("Tocantins (TO)");
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            HabilitarOuDesabilitarCampos(true);
            txtNome.Focus();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            var administrador = new AdministradorModel();
            
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


                if (administrador.SenhasIguais)
                    MessageBox.Show(@"Senhas não conferem");

                MessageBox.Show(@"Administrador cadastrado com sucesso!");
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CmbEstado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbCidade.Text = string.Empty;
            cmbCidade.Items.Clear();
            if (cmbEstado.SelectedItem.Equals("São Paulo (SP)"))
            {
                cmbCidade.Items.Add("Jales");
                cmbCidade.Items.Add("Urânia");
                cmbCidade.Items.Add("Fernandopolis");
            }
            else if (cmbEstado.SelectedItem.Equals("Bahia (BA)"))
            {
                cmbCidade.Items.Add("Salvador");
                cmbCidade.Items.Add("Itacaré");
                cmbCidade.Items.Add("Porto Seguro");
            }
        }
    }
}
