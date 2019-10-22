using System;
using System.Windows.Forms;
using ProjetoDesafio.Feature.Administrador.View;
using ProjetoDesafio.Feature.Fornecedor.View;
using ProjetoDesafio.Feature.Funcionario.View;

namespace ProjetoDesafio.Feature.Menu
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void BtnFuncionario_Click(object sender, EventArgs e)
        {
            Hide();
            var principal = new FrmFuncionario();
            principal.Closed += (s, args) => Close();
            principal.Show();
        }

        private void BtnFornecedor_Click(object sender, EventArgs e)
        {
            Hide();
            var principal = new FrmFornecedor();
            principal.Closed += (s, args) => Close();
            principal.Show();
        }

        private void BtnAdministrador_Click(object sender, EventArgs e)
        {
            Hide();
            var principal = new FrmAdministrador();
            principal.Closed += (s, args) => Close();
            principal.Show();
        }
    }
}
