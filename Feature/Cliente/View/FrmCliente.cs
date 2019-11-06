using System;
using System.Windows.Forms;
using ProjetoDesafio.Feature.Cliente.Controller;
using ProjetoDesafio.Feature.Cliente.Model;

namespace ProjetoDesafio.Feature.Cliente.View
{
    public partial class FrmCliente : Form
    {
        private readonly ClienteController _clienteController;
        private readonly ClienteModel _clienteModel;

        public FrmCliente()
        {
            InitializeComponent();
            _clienteModel = new ClienteModel();
            _clienteController = new ClienteController();
            SelecionarEstado();
            HabilitarOuDesabilitarCampos(false);
            LimparCampos();
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
            txtProfissao.Enabled = habilitarCampos;
            mskTelefone.Enabled = habilitarCampos;
            mskRg.Enabled = habilitarCampos;
            mskCpf.Enabled = habilitarCampos;
            dtCadastro.Enabled = habilitarCampos;
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

        private void LimparCampos()
        {
            txtNome.Text = string.Empty;
            txtRua.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtCep.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            txtBairro.Text = string.Empty;
            cmbCidade.Text = string.Empty;
            cmbEstado.Text = string.Empty;
            txtPais.Text = string.Empty;
            dtNascimento.Text = string.Empty;
            cmbSexo.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtProfissao.Text = string.Empty;
            mskTelefone.Text = string.Empty;
            mskRg.Text = string.Empty;
            mskCpf.Text = string.Empty;
            dtCadastro.Text = string.Empty;

        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            HabilitarOuDesabilitarCampos(true);
            txtNome.Focus();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            _clienteModel.NomePessoa = txtNome.Text;
            _clienteModel.Endereco.Cep = txtCep.Text;
            _clienteModel.Endereco.Rua = txtRua.Text;
            _clienteModel.Endereco.Numero = txtNumero.Text;
            _clienteModel.Endereco.Complemento = txtComplemento.Text;
            _clienteModel.Endereco.Bairro = txtBairro.Text;
            _clienteModel.Endereco.Cidade = cmbCidade.Text;
            _clienteModel.Endereco.Estado = cmbEstado.Text;
            _clienteModel.Endereco.Pais = txtPais.Text;
            _clienteModel.EmailPessoa = txtEmail.Text;
            _clienteModel.TelefonePessoa = mskTelefone.Text;
            _clienteModel.ProfissaoCliente = txtProfissao.Text;
            _clienteModel.DataCadastro = DateTime.Parse(dtCadastro.Text);
            _clienteModel.Sexo = cmbSexo.Text;
            _clienteModel.DataNascimento = DateTime.Parse(dtNascimento.Text);
            _clienteModel.RgIe = mskRg.Text;
            _clienteModel.CpfCnpj = mskCpf.Text;

            if (_clienteController.Cadastrar(_clienteModel))
                LimparCampos();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CmbEstado_SelectedIndexChanged(object sender, EventArgs e)
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

        private bool ValidarCampos()
        {
            if (!string.IsNullOrWhiteSpace(txtNome.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Nome' é obrigatório.");
                return false;
            }
            if (!string.IsNullOrWhiteSpace(txtBairro.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Bairro' é obrigatório.");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtCep.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Cep' é obrigatório.");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtEmail.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Email' é obrigatório.");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtNumero.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Número' é obrigatório.");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtPais.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'País' é obrigatório.");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtProfissao.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Profissão' é obrigatório.");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtRua.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Rua' é obrigatório.");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(cmbSexo.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Sexo' é obrigatório.");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(cmbEstado.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Estado' é obrigatório.");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(cmbCidade.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Cidade' é obrigatório.");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(mskCpf.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'CPF' é obrigatório.");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(mskRg.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'RG' é obrigatório.");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(mskTelefone.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Telefone' é obrigatório.");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(dtNascimento.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Nascimento' é obrigatório.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(dtCadastro.Text.Trim())) return true;
            MessageBox.Show(@"Campo 'Data de cadastro' é obrigatório.");
            return false;
        }
    }
}
