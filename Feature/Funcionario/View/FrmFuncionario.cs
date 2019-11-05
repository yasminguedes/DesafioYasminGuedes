using System;
using ProjetoDesafio.Feature.Funcionario.Controller;
using ProjetoDesafio.Feature.Funcionario.Model;
using System.Windows.Forms;

namespace ProjetoDesafio.Feature.Funcionario.View
{
    public partial class FrmFuncionario : Form
    {
        private readonly FuncionarioController _funcionarioController;
        private readonly FuncionarioModel _funcionarioModel;
        public FrmFuncionario()
        {
            InitializeComponent();
            _funcionarioModel = new FuncionarioModel();
            _funcionarioController = new FuncionarioController();
            HabilitarOuDesabilitarCampos(false);
            SelecionarEstado();
            LimparCampos();
            PreencherCargos();
        }

        private void PreencherCargos()
        {
            cmbCargo.DataSource = _funcionarioController.ListarCargos();
            cmbCargo.DisplayMember = "NomeCargo";
            cmbCargo.ValueMember = "IdCargo";
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
            cmbCargo.Text = string.Empty;
            mskTelefone.Text = string.Empty;
            mskRg.Text = string.Empty;
            mskCpf.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            mskSenha.Text = string.Empty;
            mskSenhaConfirmar.Text = string.Empty;
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
            _funcionarioModel.NomePessoa = txtNome.Text;
            _funcionarioModel.Endereco.Cep = txtCep.Text;
            _funcionarioModel.Endereco.Rua = txtRua.Text;
            _funcionarioModel.Endereco.Numero = txtNumero.Text;
            _funcionarioModel.Endereco.Bairro = txtBairro.Text;
            _funcionarioModel.Endereco.Cidade = cmbCidade.Text;
            _funcionarioModel.Endereco.Estado = cmbEstado.Text;
            _funcionarioModel.Endereco.Pais = txtPais.Text;
            _funcionarioModel.Endereco.Complemento = txtComplemento.Text;
            _funcionarioModel.Sexo = cmbSexo.Text;
            _funcionarioModel.EmailPessoa = txtEmail.Text;
            _funcionarioModel.DataNascimento = DateTime.Parse(dtNascimento.Text);
            _funcionarioModel.Cargo.IdCargo = int.Parse(cmbCargo.SelectedValue.ToString());
            _funcionarioModel.TelefonePessoa = mskTelefone.Text;
            _funcionarioModel.RgIe = mskRg.Text;
            _funcionarioModel.CpfCnpj = mskCpf.Text;
            _funcionarioModel.UsuarioFuncionario = txtUsuario.Text;
            _funcionarioModel.SenhaFuncionario = mskSenha.Text;
            _funcionarioModel.ConfirmarSenha = mskSenhaConfirmar.Text;

            
            if (_funcionarioController.Cadastrar(_funcionarioModel))
                LimparCampos();
        }

        private void BtnCancelar_Click(object sender, EventArgs e) => Close();

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

        private void btnListar_Click(object sender, EventArgs e) =>
            new FrmListagemDeFuncionarios().Show();

    }
}

