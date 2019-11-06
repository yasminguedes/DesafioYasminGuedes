using System;
using System.Windows.Forms;
using ProjetoDesafio.Feature.Fornecedor.Controller;
using ProjetoDesafio.Feature.Fornecedor.Model;

namespace ProjetoDesafio.Feature.Fornecedor.View
{
    public partial class FrmFornecedor : Form
    {
        private readonly FornecedorModel _fornecedorModel;
        private readonly FornecedorController _fornecedorController;
        public FrmFornecedor()
        {
            InitializeComponent();
            _fornecedorController = new FornecedorController();
            _fornecedorModel = new FornecedorModel();
            HabilitarOuDesabilitarCampos(false);
            SelecionarEstado();
            LimparCampos();
        }
        private void LimparCampos()
        {
            txtNome.Text= string.Empty;
            txtRua.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtCep.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            txtBairro.Text = string.Empty;
            cmbCidade.Text = string.Empty;
            cmbEstado.Text = string.Empty;
            txtPais.Text = string.Empty;
            txtRazaoSocial.Text = string.Empty;
            txtEmail.Text = string.Empty;
            mskTelefone.Text = string.Empty;
            mskIe.Text = string.Empty;
            mskCnpj.Text = string.Empty;
            txtRepresentante.Text = string.Empty;
            txtEmailRepresentante.Text = string.Empty;
            mskCelular.Text = string.Empty;
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
            txtRazaoSocial.Enabled = habilitarCampos;
            txtEmail.Enabled = habilitarCampos;
            mskTelefone.Enabled = habilitarCampos;
            mskIe.Enabled = habilitarCampos;
            mskCnpj.Enabled = habilitarCampos;
            txtRepresentante.Enabled = habilitarCampos;
            txtEmailRepresentante.Enabled = habilitarCampos;
            mskCelular.Enabled = habilitarCampos;
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
            if(!ValidarCampos()) return;
            _fornecedorModel.NomePessoa = txtNome.Text;
            _fornecedorModel.Endereco.Cep = txtCep.Text;
            _fornecedorModel.Endereco.Rua = txtRua.Text;
            _fornecedorModel.Endereco.Numero = txtNumero.Text;
            _fornecedorModel.Endereco.Complemento = txtComplemento.Text;
            _fornecedorModel.Endereco.Bairro = txtBairro.Text;
            _fornecedorModel.Endereco.Cidade = cmbCidade.Text;
            _fornecedorModel.Endereco.Estado = cmbEstado.Text;
            _fornecedorModel.Endereco.Pais = txtPais.Text;
            _fornecedorModel.EmailPessoa = txtEmail.Text;
            _fornecedorModel.TelefonePessoa = mskTelefone.Text;
            _fornecedorModel.RgIe = mskIe.Text;
            _fornecedorModel.CpfCnpj = mskCnpj.Text;
            _fornecedorModel.RazaoSocial = txtRazaoSocial.Text;
            _fornecedorModel.Representante = txtRepresentante.Text;
            _fornecedorModel.EmailRepresentante = txtEmailRepresentante.Text;
            _fornecedorModel.CelularRepresentante = mskCelular.Text;

            _fornecedorController.Cadastrar(_fornecedorModel);
            LimparCampos();
            
        }

        private void BtnCancelar_Click(object sender, EventArgs e) =>Close();
        
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

        private void BtnListar_Click(object sender, EventArgs e)
        {
            new FrmListagemDeFornecedor().Show();
        }

        private bool ValidarCampos()
        {
            if (!string.IsNullOrWhiteSpace(txtNome.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Nome Fantasia' é obrigatório.");
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

            if (!string.IsNullOrWhiteSpace(txtRazaoSocial.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Profissão' é obrigatório.");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtRua.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Rua' é obrigatório.");
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

            if (!string.IsNullOrWhiteSpace(mskCnpj.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Cnpj' é obrigatório.");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(mskIe.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'IE' é obrigatório.");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(mskTelefone.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Telefone' é obrigatório.");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtEmailRepresentante.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Email Representante' é obrigatório.");
                return false;
            }
            if (!string.IsNullOrWhiteSpace(txtRepresentante.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Representante' é obrigatório.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(mskCelular.Text.Trim())) return true;
            MessageBox.Show(@"Campo 'Celular' é obrigatório.");
            return false;
        }
    }
}
