using System;
using System.Windows.Forms;
using ProjetoDesafio.Feature.Cargo.Controller;

namespace ProjetoDesafio.Feature.Cargo.View
{
    public partial class FrmCargo : Form
    {
        public FrmCargo()
        {
            InitializeComponent();
            HabilitarOuDesabilitarCampos(false);
            LimparCampos();
        }
        private void LimparCampos()
        {
            txtCargo.Text = "";
        }
        private void HabilitarOuDesabilitarCampos(bool habilitarCampos)
        {
            txtCargo.Enabled = habilitarCampos;
        }
        
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            var cargo = new CargoModel.CargoModel()
            {
                NomeCargo = txtCargo.Text
            };
            new CargoController().Cadastrar(cargo);
            LimparCampos();
        }

        private void BtnCadastrar_Click_1(object sender, EventArgs e)
        {
            HabilitarOuDesabilitarCampos(true);
            txtCargo.Focus();
        }
    }
}
