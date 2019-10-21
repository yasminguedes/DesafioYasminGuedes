using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoDesafio.Feature.Funcionario.View;

namespace ProjetoDesafio.Feature.TelaLogin
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            var usuario = txtUsuario.Text;
            var senha = txtSenha.Text;
            if("usuario".Equals(usuario) && "1234".Equals(senha))
            {
                Hide();
                var principal = new FrmMenu();
                principal.Closed += (s, args) => Close();
                principal.Show();
            }
            else
            {
                MessageBox.Show(@"Usuário e/ou senha inválido(s)!");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }
    }
}
