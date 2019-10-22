using System;
using System.Windows.Forms;
using ProjetoDesafio.Feature.Menu;

namespace ProjetoDesafio.Feature.Tela_Login
{
    public partial class FrmLogar : Form
    {
        public FrmLogar()
        {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            var usuario = txtUsuario.Text;
            var senha = txtSenha.Text;
            if ("usuario".Equals(usuario) && "1234".Equals(senha))
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

        private void Login_Load(object sender, EventArgs e) => txtUsuario.Focus();
        
    }
}
  

