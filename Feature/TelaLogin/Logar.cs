using System;
using System.Windows.Forms;
using ProjetoDesafio.Feature.Menu;

namespace ProjetoDesafio.Feature.TelaLogin
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
            if ("usuario".Equals(usuario) && !"1234".Equals(senha))
            {
                pctCheck.Visible = true;
                pctErrado2.Visible = true;
                MessageBox.Show(@"Senha Inválida");
            }
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

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            if ("usuario".Equals((txtUsuario.Text)))
            {
                pctCheck.Visible = true;
                pctErrado.Visible = false;
            }
            else
            {
                pctErrado.Visible = true;
                pctCheck.Visible = false;
            }
        }

        private void TxtSenha_Leave(object sender, EventArgs e)
        {
            if ("1234".Equals(txtSenha.Text))
            {
                pctCheck2.Visible = true;
                pctErrado2.Visible = false;
            }
            else
            {
                pctErrado2.Visible = true;
                pctCheck2.Visible = false;
            }
        }

        private void TxtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnEntrar_Click(sender,e);
        }

        private void FrmLogar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnEntrar_Click(sender, e);
        }
    }
}
  

