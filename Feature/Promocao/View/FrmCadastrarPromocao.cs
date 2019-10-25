using System;
using System.Windows.Forms;

namespace ProjetoDesafio.Feature.Promocao.View
{
    public partial class FrmCadastroPromocao : Form
    {
        public FrmCadastroPromocao()
        {
            InitializeComponent();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            new FrmSelecionarProdutos().Show();
        }
    }
}
