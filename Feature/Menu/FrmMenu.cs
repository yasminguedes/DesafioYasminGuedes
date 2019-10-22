using System;
using System.Windows.Forms;
using ProjetoDesafio.Feature.Administrador.View;
using ProjetoDesafio.Feature.Cliente.View;
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
            new FrmFuncionario().Show();
        }

        private void BtnFornecedor_Click(object sender, EventArgs e)
        {
            new FrmFornecedor().Show();
        }

        private void BtnAdministrador_Click(object sender, EventArgs e)
        {
            new FrmAdministrador().Show();
        }

        private void BtnCliente(object sender, EventArgs e)
        {
            new FrmCliente().Show();
        }
    }
}
