using System;
using System.Windows.Forms;
using ProjetoDesafio.Feature.Cargo.Controller;
using ProjetoDesafio.Feature.Cargo.Model;

namespace ProjetoDesafio.Feature.Cargo.View
{
    public partial class FrmCargo : Form
    {
        private readonly CargoController _cargoController;
        private readonly CargoModel _cargoModel;
        public FrmCargo()
        {
            InitializeComponent();
            _cargoModel = new CargoModel();
            _cargoController = new CargoController();
            HabilitarOuDesabilitarCampos(false);
            LimparCampos();
        }

        private void LimparCampos()=> txtCargo.Text = string.Empty;
        
        private void HabilitarOuDesabilitarCampos(bool habilitarCampos) => txtCargo.Enabled = habilitarCampos;
        
       private void BtnCadastrar_Click_1(object sender, EventArgs e)
        {
            HabilitarOuDesabilitarCampos(true);
            txtCargo.Focus();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            _cargoModel.NomeCargo = txtCargo.Text;

            if (_cargoController.Cadastrar(_cargoModel))
                LimparCampos();
        }

        private void BtnCancelar_Click(object sender, EventArgs e) => Close();
    }
}
