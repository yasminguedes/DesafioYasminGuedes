﻿using System;
using System.Windows.Forms;

namespace ProjetoDesafio.Feature.Cliente.View
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
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
            txtProfissao.Text = "";
            mskTelefone.Text = "";
            mskRg.Text = "";
            mskCpf.Text = "";
            dtCadastro.Text = "";
            
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            HabilitarOuDesabilitarCampos(true);
            txtNome.Focus();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Cliente cadastrado com sucesso!");
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
    }
}
